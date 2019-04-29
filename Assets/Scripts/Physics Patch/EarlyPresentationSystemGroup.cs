using UnityEngine;
using Unity.Entities;
using Unity.Collections;

namespace RogueGo {
  [UpdateInGroup(typeof(PresentationSystemGroup))]
  [UpdateBefore(typeof(MainPresentationSystemGroup))]
  public class EarlyPresentationSystemGroup : ComponentSystemGroup {

  }
}