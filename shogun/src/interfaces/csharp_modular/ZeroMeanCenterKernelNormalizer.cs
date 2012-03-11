/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ZeroMeanCenterKernelNormalizer : KernelNormalizer {
  private HandleRef swigCPtr;

  internal ZeroMeanCenterKernelNormalizer(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.ZeroMeanCenterKernelNormalizerUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ZeroMeanCenterKernelNormalizer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ZeroMeanCenterKernelNormalizer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_ZeroMeanCenterKernelNormalizer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ZeroMeanCenterKernelNormalizer() : this(modshogunPINVOKE.new_ZeroMeanCenterKernelNormalizer(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool alloc_and_compute_row_means(Kernel k, SWIGTYPE_p_double v, int num_lhs, int num_rhs) {
    bool ret = modshogunPINVOKE.ZeroMeanCenterKernelNormalizer_alloc_and_compute_row_means(swigCPtr, Kernel.getCPtr(k), SWIGTYPE_p_double.getCPtr(v), num_lhs, num_rhs);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}