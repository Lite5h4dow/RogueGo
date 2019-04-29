using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace RogueGo {
  [UpdateInGroup (typeof (PresentationSystemGroup))]
  [UpdateAfter (typeof (MainPresentationSystemGroup))]
  public class LatePresentationSystemGroup : ComponentSystemGroup {

  }
}