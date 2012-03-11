/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CombinedFeatures : Features {
  private HandleRef swigCPtr;

  internal CombinedFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.CombinedFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CombinedFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CombinedFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_CombinedFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CombinedFeatures() : this(modshogunPINVOKE.new_CombinedFeatures__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CombinedFeatures(CombinedFeatures orig) : this(modshogunPINVOKE.new_CombinedFeatures__SWIG_1(CombinedFeatures.getCPtr(orig)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void list_feature_objs() {
    modshogunPINVOKE.CombinedFeatures_list_feature_objs(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool check_feature_obj_compatibility(CombinedFeatures comb_feat) {
    bool ret = modshogunPINVOKE.CombinedFeatures_check_feature_obj_compatibility(swigCPtr, CombinedFeatures.getCPtr(comb_feat));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Features get_first_feature_obj() {
    IntPtr cPtr = modshogunPINVOKE.CombinedFeatures_get_first_feature_obj__SWIG_0(swigCPtr);
    Features ret = (cPtr == IntPtr.Zero) ? null : new Features(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Features get_first_feature_obj(ListElement current) {
    IntPtr cPtr = modshogunPINVOKE.CombinedFeatures_get_first_feature_obj__SWIG_1(swigCPtr, ListElement.getCPtr(current));
    Features ret = (cPtr == IntPtr.Zero) ? null : new Features(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Features get_next_feature_obj() {
    IntPtr cPtr = modshogunPINVOKE.CombinedFeatures_get_next_feature_obj__SWIG_0(swigCPtr);
    Features ret = (cPtr == IntPtr.Zero) ? null : new Features(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Features get_next_feature_obj(ListElement current) {
    IntPtr cPtr = modshogunPINVOKE.CombinedFeatures_get_next_feature_obj__SWIG_1(swigCPtr, ListElement.getCPtr(current));
    Features ret = (cPtr == IntPtr.Zero) ? null : new Features(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Features get_last_feature_obj() {
    IntPtr cPtr = modshogunPINVOKE.CombinedFeatures_get_last_feature_obj(swigCPtr);
    Features ret = (cPtr == IntPtr.Zero) ? null : new Features(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool insert_feature_obj(Features obj) {
    bool ret = modshogunPINVOKE.CombinedFeatures_insert_feature_obj(swigCPtr, Features.getCPtr(obj));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool append_feature_obj(Features obj) {
    bool ret = modshogunPINVOKE.CombinedFeatures_append_feature_obj(swigCPtr, Features.getCPtr(obj));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool delete_feature_obj() {
    bool ret = modshogunPINVOKE.CombinedFeatures_delete_feature_obj(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_num_feature_obj() {
    int ret = modshogunPINVOKE.CombinedFeatures_get_num_feature_obj(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}