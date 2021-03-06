/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class WaveletKernel : DotKernel {
  private HandleRef swigCPtr;

  internal WaveletKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.WaveletKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(WaveletKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~WaveletKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_WaveletKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public WaveletKernel() : this(modshogunPINVOKE.new_WaveletKernel__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public WaveletKernel(int size, double Wdilation, double Wtranslation) : this(modshogunPINVOKE.new_WaveletKernel__SWIG_1(size, Wdilation, Wtranslation), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public WaveletKernel(DotFeatures l, DotFeatures r, int size, double Wdilation, double Wtranslation) : this(modshogunPINVOKE.new_WaveletKernel__SWIG_2(DotFeatures.getCPtr(l), DotFeatures.getCPtr(r), size, Wdilation, Wtranslation), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
