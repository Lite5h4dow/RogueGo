using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class DodgeRechargeTimerSystem : ComponentSystem {
    EntityQuery timer;

    protected override void OnCreateManager() {
      timer = GetEntityQuery(
        typeof(ReadyToDodge),
        typeof(MaxDodges),
        typeof(CurrentDodges)
      );
    }

    protected override void OnUpdate() {
      Entities.With(timer).ForEach((ref ReadyToDodge rtd, ref MaxDodges md, ref CurrentDodges cd) => {
        if (md.Value == cd.Value)
          return;

        rtd.Value += Time.deltaTime;
      });

    }
  }
}