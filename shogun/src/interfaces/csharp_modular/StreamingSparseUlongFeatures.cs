/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class StreamingSparseUlongFeatures : StreamingDotFeatures {
  private HandleRef swigCPtr;

  internal StreamingSparseUlongFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.StreamingSparseUlongFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StreamingSparseUlongFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StreamingSparseUlongFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_StreamingSparseUlongFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public StreamingSparseUlongFeatures() : this(modshogunPINVOKE.new_StreamingSparseUlongFeatures__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingSparseUlongFeatures(StreamingFile file, bool is_labelled, int size) : this(modshogunPINVOKE.new_StreamingSparseUlongFeatures__SWIG_1(StreamingFile.getCPtr(file), is_labelled, size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ulong get_feature(int index) {
    ulong ret = modshogunPINVOKE.StreamingSparseUlongFeatures_get_feature(swigCPtr, index);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ULongIntSparseVector get_vector() {
    ULongIntSparseVector ret = new ULongIntSparseVector(modshogunPINVOKE.StreamingSparseUlongFeatures_get_vector(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int set_num_features(int num) {
    int ret = modshogunPINVOKE.StreamingSparseUlongFeatures_set_num_features(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void expand_if_required(SWIGTYPE_p_float vec, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingSparseUlongFeatures_expand_if_required__SWIG_0(swigCPtr, SWIGTYPE_p_float.getCPtr(vec), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void expand_if_required(SWIGTYPE_p_double vec, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingSparseUlongFeatures_expand_if_required__SWIG_1(swigCPtr, SWIGTYPE_p_double.getCPtr(vec), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public long get_num_nonzero_entries() {
    long ret = modshogunPINVOKE.StreamingSparseUlongFeatures_get_num_nonzero_entries(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float compute_squared() {
    float ret = modshogunPINVOKE.StreamingSparseUlongFeatures_compute_squared(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void sort_features() {
    modshogunPINVOKE.StreamingSparseUlongFeatures_sort_features(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
