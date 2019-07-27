﻿using SatisfactorySaveParser.Save;

namespace SatisfactorySaveParser.Game.Buildable.Factory
{
    public abstract class FGBuildablePole : FGBuildable
    {
        [SaveProperty("mHeight")]
        public float Height { get; set; }

        [SaveProperty("mPoleMesh")]
        public ObjectReference PoleMesh { get; set; }
    }
}
