/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class MultitaskKernelMaskPairNormalizer : KernelNormalizer {
  private HandleRef swigCPtr;

  internal MultitaskKernelMaskPairNormalizer(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.MultitaskKernelMaskPairNormalizerUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MultitaskKernelMaskPairNormalizer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MultitaskKernelMaskPairNormalizer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_MultitaskKernelMaskPairNormalizer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MultitaskKernelMaskPairNormalizer() : this(modshogunPINVOKE.new_MultitaskKernelMaskPairNormalizer__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public MultitaskKernelMaskPairNormalizer(SWIGTYPE_p_std__vectorT_int_t task_vector_, SWIGTYPE_p_std__vectorT_std__pairT_int_int_t_t active_pairs_) : this(modshogunPINVOKE.new_MultitaskKernelMaskPairNormalizer__SWIG_1(SWIGTYPE_p_std__vectorT_int_t.getCPtr(task_vector_), SWIGTYPE_p_std__vectorT_std__pairT_int_int_t_t.getCPtr(active_pairs_)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__vectorT_int_t get_task_vector_lhs() {
    SWIGTYPE_p_std__vectorT_int_t ret = new SWIGTYPE_p_std__vectorT_int_t(modshogunPINVOKE.MultitaskKernelMaskPairNormalizer_get_task_vector_lhs(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_task_vector_lhs(SWIGTYPE_p_std__vectorT_int_t vec) {
    modshogunPINVOKE.MultitaskKernelMaskPairNormalizer_set_task_vector_lhs(swigCPtr, SWIGTYPE_p_std__vectorT_int_t.getCPtr(vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__vectorT_int_t get_task_vector_rhs() {
    SWIGTYPE_p_std__vectorT_int_t ret = new SWIGTYPE_p_std__vectorT_int_t(modshogunPINVOKE.MultitaskKernelMaskPairNormalizer_get_task_vector_rhs(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_task_vector_rhs(SWIGTYPE_p_std__vectorT_int_t vec) {
    modshogunPINVOKE.MultitaskKernelMaskPairNormalizer_set_task_vector_rhs(swigCPtr, SWIGTYPE_p_std__vectorT_int_t.getCPtr(vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_task_vector(SWIGTYPE_p_std__vectorT_int_t vec) {
    modshogunPINVOKE.MultitaskKernelMaskPairNormalizer_set_task_vector(swigCPtr, SWIGTYPE_p_std__vectorT_int_t.getCPtr(vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double get_similarity(int task_lhs, int task_rhs) {
    double ret = modshogunPINVOKE.MultitaskKernelMaskPairNormalizer_get_similarity(swigCPtr, task_lhs, task_rhs);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_std__pairT_int_int_t_t get_active_pairs() {
    SWIGTYPE_p_std__vectorT_std__pairT_int_int_t_t ret = new SWIGTYPE_p_std__vectorT_std__pairT_int_int_t_t(modshogunPINVOKE.MultitaskKernelMaskPairNormalizer_get_active_pairs(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_normalization_constant() {
    double ret = modshogunPINVOKE.MultitaskKernelMaskPairNormalizer_get_normalization_constant(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double set_normalization_constant(double constant) {
    double ret = modshogunPINVOKE.MultitaskKernelMaskPairNormalizer_set_normalization_constant(swigCPtr, constant);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MultitaskKernelMaskPairNormalizer KernelNormalizerToMultitaskKernelMaskPairNormalizer(KernelNormalizer n) {
    IntPtr cPtr = modshogunPINVOKE.MultitaskKernelMaskPairNormalizer_KernelNormalizerToMultitaskKernelMaskPairNormalizer(swigCPtr, KernelNormalizer.getCPtr(n));
    MultitaskKernelMaskPairNormalizer ret = (cPtr == IntPtr.Zero) ? null : new MultitaskKernelMaskPairNormalizer(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}