using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class EquipInputSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(EquipPressed),
        typeof(CanEquip),
        typeof(Grounded)
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach(entity => {
        PostUpdateCommands.RemoveComponent<EquipPressed>(entity);
        PostUpdateCommands.RemoveComponent<CanEquip>(entity);
        PostUpdateCommands.AddComponent<CanUnequip>(entity, new CanUnequip { });
      });

      /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
      if (Bootstrap.DeveloperSettings.DebugEquipState) {
        Debug.Log($"<color=red>{this.GetType()}</color> Equipped");
      }
      /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
    }
  }
}