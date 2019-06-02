using System.Collections.Concurrent;

using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class UnequipInputSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(EquipPressed),
        typeof(CanUnequip),
        typeof(Grounded)
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach(entity => {
        PostUpdateCommands.RemoveComponent<EquipPressed>(entity);
        PostUpdateCommands.RemoveComponent<CanUnequip>(entity);
        PostUpdateCommands.AddComponent<CanEquip>(entity, new CanEquip { });
      });
      /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
      if (Bootstrap.DeveloperSettings.DebugEquipState) {
        Debug.Log($"<color=red>{this.GetType()}</color> Unequipped");
      }
      /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
    }
  }
}