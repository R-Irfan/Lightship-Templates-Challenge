//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Grapeshot {

public class GrapeshotBackendTopology {
  public static Topology createDefaultGCSTopology(System.Guid stage) {
var stage_Bytes = stage.ToByteArray();var stage_ByteArrayHandle = System.Runtime.InteropServices.GCHandle.Alloc(stage_Bytes ,System.Runtime.InteropServices.GCHandleType.Pinned);var stage_buffer_ptr = stage_ByteArrayHandle.AddrOfPinnedObject();
    try {
      global::System.IntPtr cPtr = GrapeshotBackendTopologyPINVOKE.createDefaultGCSTopology(stage_buffer_ptr);
      Topology ret = (cPtr == global::System.IntPtr.Zero) ? null : new Topology(cPtr, true);
      return ret;
    } finally {
stage_ByteArrayHandle.Free();
    }
  }

}

}
