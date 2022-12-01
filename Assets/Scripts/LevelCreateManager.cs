using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LevelInformation
{
    public List<string> lineInformation;
}


public class LevelCreateManager : MonoBehaviour
{
    [SerializeField]
    List<LevelInformation> LevelInformations;


    MeshRenderer MeshRenderer;
    Vector3 MinPos;
    Vector3 MaxPos;

    [SerializeField]
    GameObject PickUpObj;
    [SerializeField]
    GameObject ObstacleObj;

    [SerializeField]
    GameObject GateObj;


    List<Vector3> SpawnPositions;
 

    GameObject SpawnHolder;

    void Awake()
    {
        MeshRenderer = GetComponent<MeshRenderer>();
        MinPos = MeshRenderer.bounds.min;
        MaxPos = MeshRenderer.bounds.max;
        SpawnPositions = new List<Vector3>();       
    }



    string LIPickUpTag = "1";
    string LIObstacleTag = "2";
    string LIGateTag = "3";
    public List<int> DecodeLevelInformation(int LevelInformationID)
    {
        SpawnHolder = new GameObject("SpawnParent");
        LevelInformationID = LevelInformationID % LevelInformations.Count;
        int XItemCount = LevelInformations[LevelInformationID].lineInformation[0].Length;
        int YItemCount = LevelInformations[LevelInformationID].lineInformation.Count;

        float XIncrement = (MaxPos.x - MinPos.x) / (XItemCount + 1);
        float YIncrement = (MaxPos.z - MinPos.z) / (YItemCount + 1);

        int PickUpCounter = 0;
        int ObstacleCounter = 0;
        for (int i = 0; i < XItemCount; i++)
        {
            for (int j = 0; j < YItemCount; j++)
            {

                Vector3 SpawnPos = MinPos + XIncrement * (i + 1) * Vector3.right + YIncrement * (j + 1) * Vector3.forward;
                if (LevelInformations[LevelInformationID].lineInformation[j][i].ToString() == LIPickUpTag)
                {
                    Instantiate(PickUpObj, SpawnPos, Quaternion.identity, SpawnHolder.transform);
                    PickUpCounter++;
                }
                else if (LevelInformations[LevelInformationID].lineInformation[j][i].ToString() == LIObstacleTag)
                {
                    Instantiate(ObstacleObj, SpawnPos, Quaternion.identity, SpawnHolder.transform);
                    ObstacleCounter++;
                }

                else if (LevelInformations[LevelInformationID].lineInformation[j][i].ToString() == LIGateTag)
                {
                    Instantiate(GateObj, SpawnPos, Quaternion.identity, SpawnHolder.transform);
                    
                }
                
            }
        }
        return new List<int>() { PickUpCounter, ObstacleCounter };
    }

    public void ClearLevel()
    {
        Destroy(SpawnHolder);
    }
}
