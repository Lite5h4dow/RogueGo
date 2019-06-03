using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class DodgeRechargeSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(MaxDodges),
        typeof(CurrentDodges),
        typeof(ReadyToDodge),
        typeof(DodgeRechargeTime)
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach((ref MaxDodges md, ref CurrentDodges cd, ref ReadyToDodge rtd, ref DodgeRechargeTime drt) => {
        if (rtd.Value < drt.Value)
          return;

        if (cd.Value == md.Value)
          return;

        cd.Value++;
        rtd.Value = 0;

        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
        if (Bootstrap.DeveloperSettings.DebugDodgeState) {
          Debug.Log($"<color=blue>{this.GetType()}</color> Dodge Added");
        }
        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
      });
    }
  }
}