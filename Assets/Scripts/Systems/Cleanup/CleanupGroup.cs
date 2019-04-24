using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace RogueGo {
  [UpdateAfter (typeof (UnityEngine.Experimental.PlayerLoop.PreLateUpdate))]
  public class CleanupGroup : ComponentSystemGroup { }
}