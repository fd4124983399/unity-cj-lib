﻿/******************************************************************************/
/*
  Project - Unity CJ Lib
            https://github.com/TheAllenChou/unity-cj-lib
  
  Author  - Ming-Lun "Allen" Chou
  Web     - http://AllenChou.net
  Twitter - @TheAllenChou
*/
/******************************************************************************/

using CjLib;
using UnityEngine;

public class BoxComponent : CjLibDemoComponent
{
  [Range(0.1f, 10.0f)]
  public float dimensionX = 1.0f;

  [Range(0.1f, 10.0f)]
  public float dimensionY = 1.0f;

  [Range(0.1f, 10.0f)]
  public float dimensionZ = 1.0f;

  protected override void Draw()
  {
    DebugUtil.DrawBox(transform.position, new Vector3(dimensionX, dimensionY, dimensionZ), transform.rotation, Color.white);
  }

}