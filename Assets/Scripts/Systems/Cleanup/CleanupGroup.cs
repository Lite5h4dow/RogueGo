using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace RogueGo {
  [UpdateAfter (typeof (LatePresentationSystemGroup))]
  public class CleanupGroup : ComponentSystemGroup { }
}