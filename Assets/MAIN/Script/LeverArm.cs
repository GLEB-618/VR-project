using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class LeverArm : MonoBehaviour
{
    public Transform startPosition;
    public Transform endPosition;
    public float LinearMapping = 0;
    public bool repositionGameObject = true;
    public bool maintainMomemntum = true;
    public float momemtumDampenRate = 5.0f;

    protected Hand.AttachmentFlags attachmentFlags = Hand.AttachmentFlags.DetachFromOtherHand;

    protected float initialMappingOffset;
    protected int numMappingChangeSamples = 5;
    protected float[] mappingChangeSamples;
    protected float prevMapping = 0.0f;
    protected float mappingChangeRate;
    protected int sampleCount = 0;

    protected Interactable interactable;


    protected virtual void Awake()
    {
        mappingChangeSamples = new float[numMappingChangeSamples];
        interactable = GetComponent<Interactable>();
    }

    protected virtual void HandHoverUpdate(Hand hand)
    {
        GrabTypes startingGrabType = hand.GetGrabStarting();

        if (interactable.attachedToHand == null && startingGrabType != GrabTypes.None)
        {
            initialMappingOffset = LinearMapping - CalculateLinearMapping(hand.transform);
            sampleCount = 0;
            mappingChangeRate = 0.0f;

            hand.AttachObject(gameObject, startingGrabType, attachmentFlags);
        }
    }

    protected virtual void HandAttachedUpdate(Hand hand)
    {
        UpdateLinearMapping(hand.transform);

        if (hand.IsGrabEnding(this.gameObject))
        {
            hand.DetachObject(gameObject);
        }
    }

    protected virtual void OnDetachedFromHand(Hand hand)
    {
        CalculateMappingChangeRate();
    }


    protected void CalculateMappingChangeRate()
    {
        //Compute the mapping change rate
        mappingChangeRate = 0.0f;
        int mappingSamplesCount = Mathf.Min(sampleCount, mappingChangeSamples.Length);
        if (mappingSamplesCount != 0)
        {
            for (int i = 0; i < mappingSamplesCount; ++i)
            {
                mappingChangeRate += mappingChangeSamples[i];
            }
            mappingChangeRate /= mappingSamplesCount;
        }
    }

    protected void UpdateLinearMapping(Transform updateTransform)
    {
        prevMapping = LinearMapping;
        LinearMapping = Mathf.Clamp01(initialMappingOffset + CalculateLinearMapping(updateTransform));

        mappingChangeSamples[sampleCount % mappingChangeSamples.Length] = (1.0f / Time.deltaTime) * (LinearMapping - prevMapping);
        sampleCount++;

        if (repositionGameObject)
        {
            transform.position = Vector3.Lerp(startPosition.position, endPosition.position, LinearMapping);
        }
    }

    protected float CalculateLinearMapping(Transform updateTransform)
    {
        Vector3 direction = endPosition.position - startPosition.position;
        float length = direction.magnitude;
        direction.Normalize();

        Vector3 displacement = updateTransform.position - startPosition.position;

        return Vector3.Dot(displacement, direction) / length;
    }


    //protected virtual void Update()
    //{
    //    if (maintainMomemntum && mappingChangeRate != 0.0f)
    //    {
    //        //Dampen the mapping change rate and apply it to the mapping
    //        mappingChangeRate = Mathf.Lerp(mappingChangeRate, 0.0f, momemtumDampenRate * Time.deltaTime);
    //        LinearMapping = Mathf.Clamp01(LinearMapping + (mappingChangeRate * Time.deltaTime));

    //        if (repositionGameObject)
    //        {
    //            transform.position = Vector3.Lerp(startPosition.position, endPosition.position, LinearMapping);
    //        }
    //    }
    //}
}
