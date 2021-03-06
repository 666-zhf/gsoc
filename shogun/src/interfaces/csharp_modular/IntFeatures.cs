/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class IntFeatures : DotFeatures {
  private HandleRef swigCPtr;

  internal IntFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.IntFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IntFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IntFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_IntFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public IntFeatures(int size) : this(modshogunPINVOKE.new_IntFeatures__SWIG_0(size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public IntFeatures() : this(modshogunPINVOKE.new_IntFeatures__SWIG_1(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public IntFeatures(IntFeatures orig) : this(modshogunPINVOKE.new_IntFeatures__SWIG_2(IntFeatures.getCPtr(orig)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public IntFeatures(int[,] matrix) : this(modshogunPINVOKE.new_IntFeatures__SWIG_3(matrix.GetLength(0), matrix.GetLength(1), matrix), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public IntFeatures(File loader) : this(modshogunPINVOKE.new_IntFeatures__SWIG_4(File.getCPtr(loader)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void free_feature_matrix() {
    modshogunPINVOKE.IntFeatures_free_feature_matrix(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void free_features() {
    modshogunPINVOKE.IntFeatures_free_features(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_feature_vector(int[] vector, int num) {
    modshogunPINVOKE.IntFeatures_set_feature_vector(swigCPtr, vector.Length, vector, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int[] get_feature_vector(int num) {
		IntPtr ptr = modshogunPINVOKE.IntFeatures_get_feature_vector(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		int[] ret = new int[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public int[,] get_feature_matrix() {
	IntPtr ptr = modshogunPINVOKE.IntFeatures_get_feature_matrix(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
	int[] ranks = new int[2];
	Marshal.Copy(ptr, ranks, 0, 2);

	int rows = ranks[0];
	int cols = ranks[1];
	int len = rows * cols;

	int[] ret = new int[len];

	Marshal.Copy(new IntPtr(ptr.ToInt64() + 2 * Marshal.SizeOf(typeof(int))), ret, 0, len);

	int[,] result = new int[rows, cols];
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < cols; j++) {
			result[i, j] = ret[i * cols + j];
		}
	}
	return result;
}

  public int[,] steal_feature_matrix() {
	IntPtr ptr = modshogunPINVOKE.IntFeatures_steal_feature_matrix(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
	int[] ranks = new int[2];
	Marshal.Copy(ptr, ranks, 0, 2);

	int rows = ranks[0];
	int cols = ranks[1];
	int len = rows * cols;

	int[] ret = new int[len];

	Marshal.Copy(new IntPtr(ptr.ToInt64() + 2 * Marshal.SizeOf(typeof(int))), ret, 0, len);

	int[,] result = new int[rows, cols];
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < cols; j++) {
			result[i, j] = ret[i * cols + j];
		}
	}
	return result;
}

  public void set_feature_matrix(int[,] matrix) {
    modshogunPINVOKE.IntFeatures_set_feature_matrix(swigCPtr, matrix.GetLength(0), matrix.GetLength(1), matrix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public IntFeatures get_transposed() {
    IntPtr cPtr = modshogunPINVOKE.IntFeatures_get_transposed(swigCPtr);
    IntFeatures ret = (cPtr == IntPtr.Zero) ? null : new IntFeatures(cPtr, true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void copy_feature_matrix(int[,] src) {
    modshogunPINVOKE.IntFeatures_copy_feature_matrix(swigCPtr, src.GetLength(0), src.GetLength(1), src);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void obtain_from_dot(DotFeatures df) {
    modshogunPINVOKE.IntFeatures_obtain_from_dot(swigCPtr, DotFeatures.getCPtr(df));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool apply_preprocessor(bool force_preprocessing) {
    bool ret = modshogunPINVOKE.IntFeatures_apply_preprocessor__SWIG_0(swigCPtr, force_preprocessing);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool apply_preprocessor() {
    bool ret = modshogunPINVOKE.IntFeatures_apply_preprocessor__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_num_features() {
    int ret = modshogunPINVOKE.IntFeatures_get_num_features(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_num_features(int num) {
    modshogunPINVOKE.IntFeatures_set_num_features(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_num_vectors(int num) {
    modshogunPINVOKE.IntFeatures_set_num_vectors(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void initialize_cache() {
    modshogunPINVOKE.IntFeatures_initialize_cache(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool Align_char_features(StringCharFeatures cf, StringCharFeatures Ref, double gapCost) {
    bool ret = modshogunPINVOKE.IntFeatures_Align_char_features(swigCPtr, StringCharFeatures.getCPtr(cf), StringCharFeatures.getCPtr(Ref), gapCost);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
