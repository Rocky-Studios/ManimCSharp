using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manim
{
    public class Scene
    {
        public string Name = "Scene";
        /// <summary>
        /// All of the objects in the scene. Note: adding objects here will not do anything visually, you need to create animations for that.
        /// </summary>
        public List<MObject> MObjects = new();
        /// <summary>
        /// A list of all the animations in the scene
        /// </summary>
        public List<IAnimation> Animations = new();
    }
}
