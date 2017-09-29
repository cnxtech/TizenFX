/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

namespace Tizen.NUI
{
    /// <summary>
    /// TextureSet is a handle to an object that specifies the set of images used as textures by a renderer.<br>
    /// The images have to be ordered in the same order they are declared in the shader.
    /// </summary>
    public class TextureSet : BaseHandle
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal TextureSet(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.TextureSet_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TextureSet obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        protected override void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.

            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicPINVOKE.delete_TextureSet(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            base.Dispose(type);
        }

        /// <summary>
        /// Create an instance of TextureSet.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public TextureSet() : this(NDalicPINVOKE.TextureSet_New(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }

        /// <summary>
        /// Sets the texture at position "index".
        /// </summary>
        /// <param name="index">The position in the texture set of the texture.</param>
        /// <param name="texture">The texture.</param>
        /// <since_tizen> 3 </since_tizen>
        public void SetTexture(uint index, Texture texture)
        {
            NDalicPINVOKE.TextureSet_SetTexture(swigCPtr, index, Texture.getCPtr(texture));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Gets the image at position "index".
        /// </summary>
        /// <param name="index">The position in the texture set of the image.</param>
        /// <returns>A handle to the image at the the specified position.</returns>
        /// <since_tizen> 3 </since_tizen>
        public Texture GetTexture(uint index)
        {
            System.IntPtr cPtr = NDalicPINVOKE.TextureSet_GetTexture(swigCPtr, index);
            Texture ret = Registry.GetManagedBaseHandleFromNativePtr(cPtr) as Texture;

            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Sets the sampler to be used by the image at position "index".
        /// </summary>
        /// <param name="index">The position in the texture set of the image.</param>
        /// <param name="sampler">The sampler to use.</param>
        /// <since_tizen> 3 </since_tizen>
        public void SetSampler(uint index, Sampler sampler)
        {
            NDalicPINVOKE.TextureSet_SetSampler(swigCPtr, index, Sampler.getCPtr(sampler));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Sets the sampler to be used by the image at position "index".
        /// </summary>
        /// <param name="index">The position in the texture set of the image.</param>
        /// <returns>A handle to the sampler at the specified position.</returns>
        /// <since_tizen> 3 </since_tizen>
        public Sampler GetSampler(uint index)
        {
            System.IntPtr cPtr = NDalicPINVOKE.TextureSet_GetSampler(swigCPtr, index);
            Sampler ret = Registry.GetManagedBaseHandleFromNativePtr(cPtr) as Sampler;

            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Gets the number of textures present in the TextureSet.
        /// </summary>
        /// <returns>The number of textures in the TextureSet.</returns>
        /// <since_tizen> 3 </since_tizen>
        public uint GetTextureCount()
        {
            uint ret = NDalicPINVOKE.TextureSet_GetTextureCount(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

    }

}