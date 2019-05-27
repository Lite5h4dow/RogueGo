using UnityEngine;
using Unity.Entities;
using Unity.Collections;

namespace RogueGo {
  [UpdateInGroup(typeof(SimulationSystemGroup))]
  [UpdateBefore(typeof(MainSimulationSystemGroup))]
  public class EarlySimulationSystemGroup : ComponentSystemGroup {

  }
}