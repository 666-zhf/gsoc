/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class StreamingFileFromRealFeatures : StreamingFileFromFeatures {
  private HandleRef swigCPtr;

  internal StreamingFileFromRealFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.StreamingFileFromRealFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StreamingFileFromRealFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StreamingFileFromRealFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_StreamingFileFromRealFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public StreamingFileFromRealFeatures() : this(modshogunPINVOKE.new_StreamingFileFromRealFeatures__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingFileFromRealFeatures(SWIGTYPE_p_CSimpleFeaturesT_double_t feat) : this(modshogunPINVOKE.new_StreamingFileFromRealFeatures__SWIG_1(SWIGTYPE_p_CSimpleFeaturesT_double_t.getCPtr(feat)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingFileFromRealFeatures(SWIGTYPE_p_CSimpleFeaturesT_double_t feat, SWIGTYPE_p_double lab) : this(modshogunPINVOKE.new_StreamingFileFromRealFeatures__SWIG_2(SWIGTYPE_p_CSimpleFeaturesT_double_t.getCPtr(feat), SWIGTYPE_p_double.getCPtr(lab)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
