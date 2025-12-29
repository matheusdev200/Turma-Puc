using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEditor.UIElements;

[CreateAssetMenu(menuName = "Quests/Quest")]
public class Quest : ScriptableObject
{
    public string questID;
    public string questName;
    public string description;
    public List<QuestObjective> objectives;

    private void OnValidate()
    {
        if (string.IsNullOrEmpty(questID))
        {
            //public string video;
            //SaveVideo(string video){  "video 3";  }
            //SaveVideo(int videoID){ todosOsVideos[videoID];}

            questID = questName + Guid.NewGuid().ToString();
        }
    }
}
[Serializable]
public class QuestObjective //classe c# raiz / tradicional
{
    //jeito principal do c# representar um objeto
    public string objectiveID;
    public string description;
    public ObjectiveType type;
    public int requiredAmount;
    public int currentAmount;

    //construtor
    //""""""método"""""" que constroi um exemplar (instância) dessa classe
    public QuestObjective(string id, string objectiveDescription, ObjectiveType t, int amount)
    {
        objectiveID = id;
        description = objectiveDescription;
        type = t;
        requiredAmount = amount;
    }

    public bool IsCompleted => currentAmount >= requiredAmount;
}

public enum ObjectiveType { CollectItem, DefeatEnemy, ReachLocation, TalkNPC, Custom }

[Serializable]
public class QuestProgress //classe que acompanha o progresso da quest a qual ele pertence
{
    public Quest quest;
    public List<QuestObjective> objectives;

    public QuestProgress(Quest quest)
    {
        this.quest = quest;
        objectives = new List<QuestObjective>();

        foreach (var obj in quest.objectives)
        {
            //método in-line
            //objectives.Add(new QuestObjective { objectiveID = obj.objectiveID,
            //description = obj.description, type = obj.type,
            //requiredAmount = obj.requiredAmount,
            //currentAmount = 0 });
            QuestObjective newObjective =
                new QuestObjective(obj.objectiveID, obj.description, obj.type, obj.requiredAmount);
            objectives.Add(newObjective);
        }
    }

    public bool IsCompleted => objectives.TrueForAll(o => o.IsCompleted);

    //public string QuestID => quest.questID;

    /*
     objectiveID = 0 -> madeira
     objectiveID = 1 -> pedra
     objectiveID = 2 -> suco de maca
     */
}
