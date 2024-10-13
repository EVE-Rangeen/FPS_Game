using Unity.FPS.Game;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class ObjectiveKillTarget : Objective
    {
        [Tooltip("Specific target that needs to be killed to complete the objective")]
        public GameObject SpecificTarget;

        protected override void Start()
        {
            base.Start();

            EventManager.AddListener<EnemyKillEvent>(OnEnemyKilled);

            // set a title and description specific for this type of objective, if it hasn't one
            if (string.IsNullOrEmpty(Title))
                Title = "Eliminate the specific target";

            if (string.IsNullOrEmpty(Description))
                Description = "Kill the specified target to complete the objective.";
        }

        void OnEnemyKilled(EnemyKillEvent evt)
        {
            if (IsCompleted)
                return;

            if (SpecificTarget != null && evt.Enemy == SpecificTarget)
            {
                Debug.Log("END");
                CompleteObjective(string.Empty, string.Empty, "Objective complete: Specific target killed");
            }
        }
    }
}