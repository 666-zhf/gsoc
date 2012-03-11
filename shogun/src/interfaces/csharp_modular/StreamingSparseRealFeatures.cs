/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class StreamingSparseRealFeatures : StreamingDotFeatures {
  private HandleRef swigCPtr;

  internal StreamingSparseRealFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.StreamingSparseRealFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StreamingSparseRealFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StreamingSparseRealFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_StreamingSparseRealFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public StreamingSparseRealFeatures() : this(modshogunPINVOKE.new_StreamingSparseRealFeatures__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingSparseRealFeatures(StreamingFile file, bool is_labelled, int size) : this(modshogunPINVOKE.new_StreamingSparseRealFeatures__SWIG_1(StreamingFile.getCPtr(file), is_labelled, size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double get_feature(int index) {
    double ret = modshogunPINVOKE.StreamingSparseRealFeatures_get_feature(swigCPtr, index);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RealSparseVector get_vector() {
    RealSparseVector ret = new RealSparseVector(modshogunPINVOKE.StreamingSparseRealFeatures_get_vector(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int set_num_features(int num) {
    int ret = modshogunPINVOKE.StreamingSparseRealFeatures_set_num_features(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void expand_if_required(SWIGTYPE_p_float vec, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingSparseRealFeatures_expand_if_required__SWIG_0(swigCPtr, SWIGTYPE_p_float.getCPtr(vec), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void expand_if_required(SWIGTYPE_p_double vec, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingSparseRealFeatures_expand_if_required__SWIG_1(swigCPtr, SWIGTYPE_p_double.getCPtr(vec), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public long get_num_nonzero_entries() {
    long ret = modshogunPINVOKE.StreamingSparseRealFeatures_get_num_nonzero_entries(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float compute_squared() {
    float ret = modshogunPINVOKE.StreamingSparseRealFeatures_compute_squared(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void sort_features() {
    modshogunPINVOKE.StreamingSparseRealFeatures_sort_features(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}