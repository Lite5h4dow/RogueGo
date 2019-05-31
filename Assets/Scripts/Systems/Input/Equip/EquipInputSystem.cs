using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  public class EquipInputSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        typeof(Player),
        ComponentType.Exclude(typeof(SwordDrawn)),
        typeof(Grounded)
      );
    }

    protected override void OnUpdate () {
      if (!Input.GetButtonDown("Equip"))
        return;

      Entities.With(player).ForEach(entity => {
        PostUpdateCommands.AddComponent<SwordDrawn>(entity, new SwordDrawn { });
      });

      /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
      if (Bootstrap.DeveloperSettings.DebugEquipState) {
        Debug.Log($"<color=red>{this.GetType()}</color> Equipped");
      }
      /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
    }
  }
}