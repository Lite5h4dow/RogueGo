using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class DodgeInputSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(ReadyToDodge),
        typeof(CurrentDodges),
        typeof(MaxDodgeTime)
      );
    }

    protected override void OnUpdate() {
      if (!Input.GetButtonDown("Dodge"))
        return;

      Entities.With(player).ForEach((Entity entity, ref CurrentDodges cd, ref MaxDodgeTime mdt) => {
        if (cd.Value == 0)
          return;

        cd.Value--;

        PostUpdateCommands.RemoveComponent<ReadyToDodge>(entity);
        PostUpdateCommands.AddComponent<Dodging>(entity, new Dodging { Value = mdt.Value });
        PostUpdateCommands.AddComponent<DodgeDown>(entity, new DodgeDown {});

        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
        if (Bootstrap.DeveloperSettings.DebugDodgeState) {
          Debug.Log($"<color=blue>{this.GetType()}</color> Dodging");
        }
        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
      });
    }
  }
}