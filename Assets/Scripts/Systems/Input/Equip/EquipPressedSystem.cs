using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  public class EquipPressedSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        typeof(Player)
      );
    }

    protected override void OnUpdate () {
      if (!Input.GetButtonDown("Equip"))
        return;

      Entities.With(player).ForEach(entity => {
        PostUpdateCommands.AddComponent<EquipPressed>(entity, new EquipPressed { });
      });
    }
  }
}