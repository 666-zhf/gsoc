/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class RidgeKernelNormalizer : KernelNormalizer {
  private HandleRef swigCPtr;

  internal RidgeKernelNormalizer(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.RidgeKernelNormalizerUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RidgeKernelNormalizer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RidgeKernelNormalizer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_RidgeKernelNormalizer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public RidgeKernelNormalizer(double r, double c) : this(modshogunPINVOKE.new_RidgeKernelNormalizer__SWIG_0(r, c), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public RidgeKernelNormalizer(double r) : this(modshogunPINVOKE.new_RidgeKernelNormalizer__SWIG_1(r), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public RidgeKernelNormalizer() : this(modshogunPINVOKE.new_RidgeKernelNormalizer__SWIG_2(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
