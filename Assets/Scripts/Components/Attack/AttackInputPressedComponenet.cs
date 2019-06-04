using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
    [Serializable]
    public struct AttackInputPressed : IComponentData {}
    public class AttackInputPressedComponenet : ComponentDataProxy<AttackInputPressed> {}
}