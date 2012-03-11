/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CustomDistance : Distance {
  private HandleRef swigCPtr;

  internal CustomDistance(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.CustomDistanceUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CustomDistance obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CustomDistance() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_CustomDistance(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CustomDistance() : this(modshogunPINVOKE.new_CustomDistance__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CustomDistance(Distance d) : this(modshogunPINVOKE.new_CustomDistance__SWIG_1(Distance.getCPtr(d)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CustomDistance(double[,] distance_matrix) : this(modshogunPINVOKE.new_CustomDistance__SWIG_2(distance_matrix.GetLength(0), distance_matrix.GetLength(1), distance_matrix), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CustomDistance(SWIGTYPE_p_double dm, int rows, int cols) : this(modshogunPINVOKE.new_CustomDistance__SWIG_3(SWIGTYPE_p_double.getCPtr(dm), rows, cols), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CustomDistance(SWIGTYPE_p_float dm, int rows, int cols) : this(modshogunPINVOKE.new_CustomDistance__SWIG_4(SWIGTYPE_p_float.getCPtr(dm), rows, cols), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool dummy_init(int rows, int cols) {
    bool ret = modshogunPINVOKE.CustomDistance_dummy_init(swigCPtr, rows, cols);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_triangle_distance_matrix_from_triangle(SWIGTYPE_p_double dm, int len) {
    bool ret = modshogunPINVOKE.CustomDistance_set_triangle_distance_matrix_from_triangle__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(dm), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_triangle_distance_matrix_from_triangle(SWIGTYPE_p_float dm, int len) {
    bool ret = modshogunPINVOKE.CustomDistance_set_triangle_distance_matrix_from_triangle__SWIG_1(swigCPtr, SWIGTYPE_p_float.getCPtr(dm), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_triangle_distance_matrix_from_full(SWIGTYPE_p_double dm, int rows, int cols) {
    bool ret = modshogunPINVOKE.CustomDistance_set_triangle_distance_matrix_from_full__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(dm), rows, cols);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_triangle_distance_matrix_from_full(SWIGTYPE_p_float dm, int rows, int cols) {
    bool ret = modshogunPINVOKE.CustomDistance_set_triangle_distance_matrix_from_full__SWIG_1(swigCPtr, SWIGTYPE_p_float.getCPtr(dm), rows, cols);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_full_distance_matrix_from_full(SWIGTYPE_p_double dm, int rows, int cols) {
    bool ret = modshogunPINVOKE.CustomDistance_set_full_distance_matrix_from_full__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(dm), rows, cols);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_full_distance_matrix_from_full(SWIGTYPE_p_float dm, int rows, int cols) {
    bool ret = modshogunPINVOKE.CustomDistance_set_full_distance_matrix_from_full__SWIG_1(swigCPtr, SWIGTYPE_p_float.getCPtr(dm), rows, cols);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual new int get_num_vec_lhs() {
    int ret = modshogunPINVOKE.CustomDistance_get_num_vec_lhs(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual new int get_num_vec_rhs() {
    int ret = modshogunPINVOKE.CustomDistance_get_num_vec_rhs(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual new bool has_features() {
    bool ret = modshogunPINVOKE.CustomDistance_has_features(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}