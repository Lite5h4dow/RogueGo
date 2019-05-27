using UnityEngine;
using Unity.Entities;
using Unity.Collections;

namespace RogueGo {
  [UpdateInGroup(typeof(SimulationSystemGroup))]
  [UpdateAfter(typeof(MainSimulationSystemGroup))]
  public class LateSimulationSystemGroup : ComponentSystemGroup {

  }
}