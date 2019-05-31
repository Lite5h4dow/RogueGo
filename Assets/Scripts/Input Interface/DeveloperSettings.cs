using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueGo {
  public class DeveloperSettings : MonoBehaviour {
    [Header("Character Controllers")]
    public bool DebugMovementInput;
    public bool DebugJumpState;
    public bool DebugBoostState;
    public bool DebugGroundedState;
    public bool DebugEquipState;
  }
}
