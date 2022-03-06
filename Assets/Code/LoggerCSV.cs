using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoggerCSV : MonoBehaviour
{
    // our trial logger component
    TrialLogger trialLogger;

    // participant id (string)
    public string participantID = "0001";

    // max number of trials
    public int numberOfTrials = 10;

    private int riddleIndex;
    private List<string> columnList;
    private float time;


    // Use this for initialization
    void Start()
    {
        // define the names of the custom datapoints we want to log
        // trial number, participant ID, trial start/end time are logged automatically
        columnList = new List<string> { "RiddleOne", "RiddleTwo", "RiddleThree" };

        // initialise trial logger
        trialLogger = GetComponent<TrialLogger>();
        trialLogger.Initialize(participantID, new List<string>(columnList));
        Debug.Log(columnList);
        // here we start the first trial immediately, you can start it at any time
        trialLogger.StartTrial();
        time = Time.time;
    }

    public void EndTime()
    {

        trialLogger.trial[columnList[riddleIndex]] = (Time.time - time).ToString("0.0");
        riddleIndex++;
        trialLogger.EndTrial();
    }

}
