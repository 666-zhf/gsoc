/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Distance : SGObject {
  private HandleRef swigCPtr;

  internal Distance(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.DistanceUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Distance obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Distance() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_Distance(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public double distance(int idx_a, int idx_b) {
    double ret = modshogunPINVOKE.Distance_distance(swigCPtr, idx_a, idx_b);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double[,] get_distance_matrix() {
	IntPtr ptr = modshogunPINVOKE.Distance_get_distance_matrix(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
	int[] ranks = new int[2];
	Marshal.Copy(ptr, ranks, 0, 2);

	int rows = ranks[0];
	int cols = ranks[1];
	int len = rows * cols;

	double[] ret = new double[len];

	Marshal.Copy(new IntPtr(ptr.ToInt64() + 2 * Marshal.SizeOf(typeof(int))), ret, 0, len);

	double[,] result = new double[rows, cols];
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < cols; j++) {
			result[i, j] = ret[i * cols + j];
		}
	}
	return result;
}

  public virtual SWIGTYPE_p_double get_distance_matrix_real(SWIGTYPE_p_int m, SWIGTYPE_p_int n, SWIGTYPE_p_double target) {
    IntPtr cPtr = modshogunPINVOKE.Distance_get_distance_matrix_real(swigCPtr, SWIGTYPE_p_int.getCPtr(m), SWIGTYPE_p_int.getCPtr(n), SWIGTYPE_p_double.getCPtr(target));
    SWIGTYPE_p_double ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_float get_distance_matrix_shortreal(SWIGTYPE_p_int m, SWIGTYPE_p_int n, SWIGTYPE_p_float target) {
    IntPtr cPtr = modshogunPINVOKE.Distance_get_distance_matrix_shortreal(swigCPtr, SWIGTYPE_p_int.getCPtr(m), SWIGTYPE_p_int.getCPtr(n), SWIGTYPE_p_float.getCPtr(target));
    SWIGTYPE_p_float ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool init(Features lhs, Features rhs) {
    bool ret = modshogunPINVOKE.Distance_init(swigCPtr, Features.getCPtr(lhs), Features.getCPtr(rhs));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void load(File loader) {
    modshogunPINVOKE.Distance_load(swigCPtr, File.getCPtr(loader));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void save(File writer) {
    modshogunPINVOKE.Distance_save(swigCPtr, File.getCPtr(writer));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public Features get_lhs() {
    IntPtr cPtr = modshogunPINVOKE.Distance_get_lhs(swigCPtr);
    Features ret = (cPtr == IntPtr.Zero) ? null : new Features(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Features get_rhs() {
    IntPtr cPtr = modshogunPINVOKE.Distance_get_rhs(swigCPtr);
    Features ret = (cPtr == IntPtr.Zero) ? null : new Features(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Features replace_rhs(Features rhs) {
    IntPtr cPtr = modshogunPINVOKE.Distance_replace_rhs(swigCPtr, Features.getCPtr(rhs));
    Features ret = (cPtr == IntPtr.Zero) ? null : new Features(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void remove_lhs_and_rhs() {
    modshogunPINVOKE.Distance_remove_lhs_and_rhs(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void remove_lhs() {
    modshogunPINVOKE.Distance_remove_lhs(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void remove_rhs() {
    modshogunPINVOKE.Distance_remove_rhs(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual EDistanceType get_distance_type() {
    EDistanceType ret = (EDistanceType)modshogunPINVOKE.Distance_get_distance_type(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual EFeatureType get_feature_type() {
    EFeatureType ret = (EFeatureType)modshogunPINVOKE.Distance_get_feature_type(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual EFeatureClass get_feature_class() {
    EFeatureClass ret = (EFeatureClass)modshogunPINVOKE.Distance_get_feature_class(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool get_precompute_matrix() {
    bool ret = modshogunPINVOKE.Distance_get_precompute_matrix(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_precompute_matrix(bool flag) {
    modshogunPINVOKE.Distance_set_precompute_matrix(swigCPtr, flag);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_num_vec_lhs() {
    int ret = modshogunPINVOKE.Distance_get_num_vec_lhs(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_num_vec_rhs() {
    int ret = modshogunPINVOKE.Distance_get_num_vec_rhs(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool has_features() {
    bool ret = modshogunPINVOKE.Distance_has_features(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool lhs_equals_rhs() {
    bool ret = modshogunPINVOKE.Distance_lhs_equals_rhs(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}