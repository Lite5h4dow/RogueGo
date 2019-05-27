using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct GameMode : ISharedComponentData {
    public Keyframe[] JumpAccelerationCurvePoints;
  }

  [RequiresEntityConversion]
  public class GameModeProxy : MonoBehaviour, IConvertGameObjectToEntity {
    // NOTE: add any values here then use this method to convert to blittable data

    // NOTE: this would go somewhere else it's just an example of what you could do
    // this would allow you to generate a curve in the editor then convert it to entity 
    // data (i use it for vehicle acceleration and braking curves. I also use it for animations)
    public AnimationCurve JumpAccelerationCurve;

    public void Convert (Entity entity, EntityManager em, GameObjectConversionSystem conversionSystem) {
      em.AddSharedComponentData(entity, new GameMode {
        JumpAccelerationCurvePoints = JumpAccelerationCurve.keys
      });
    }
  }
}