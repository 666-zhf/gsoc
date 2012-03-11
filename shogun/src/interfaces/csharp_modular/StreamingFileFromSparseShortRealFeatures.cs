/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class StreamingFileFromSparseShortRealFeatures : StreamingFileFromFeatures {
  private HandleRef swigCPtr;

  internal StreamingFileFromSparseShortRealFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.StreamingFileFromSparseShortRealFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StreamingFileFromSparseShortRealFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StreamingFileFromSparseShortRealFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_StreamingFileFromSparseShortRealFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public StreamingFileFromSparseShortRealFeatures() : this(modshogunPINVOKE.new_StreamingFileFromSparseShortRealFeatures__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingFileFromSparseShortRealFeatures(SWIGTYPE_p_CSparseFeaturesT_float_t feat) : this(modshogunPINVOKE.new_StreamingFileFromSparseShortRealFeatures__SWIG_1(SWIGTYPE_p_CSparseFeaturesT_float_t.getCPtr(feat)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingFileFromSparseShortRealFeatures(SWIGTYPE_p_CSparseFeaturesT_float_t feat, SWIGTYPE_p_double lab) : this(modshogunPINVOKE.new_StreamingFileFromSparseShortRealFeatures__SWIG_2(SWIGTYPE_p_CSparseFeaturesT_float_t.getCPtr(feat), SWIGTYPE_p_double.getCPtr(lab)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}