/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AsciiFile : File {
  private HandleRef swigCPtr;

  internal AsciiFile(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.AsciiFileUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AsciiFile obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AsciiFile() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_AsciiFile(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public AsciiFile() : this(modshogunPINVOKE.new_AsciiFile__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public AsciiFile(SWIGTYPE_p_FILE f, string name) : this(modshogunPINVOKE.new_AsciiFile__SWIG_1(SWIGTYPE_p_FILE.getCPtr(f), name), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public AsciiFile(SWIGTYPE_p_FILE f) : this(modshogunPINVOKE.new_AsciiFile__SWIG_2(SWIGTYPE_p_FILE.getCPtr(f)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public AsciiFile(string fname, char rw, string name) : this(modshogunPINVOKE.new_AsciiFile__SWIG_3(fname, rw, name), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public AsciiFile(string fname, char rw) : this(modshogunPINVOKE.new_AsciiFile__SWIG_4(fname, rw), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public AsciiFile(string fname) : this(modshogunPINVOKE.new_AsciiFile__SWIG_5(fname), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_unsigned_char vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.AsciiFile_get_vector__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(string vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.AsciiFile_get_vector__SWIG_1(swigCPtr, vector, SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_int vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.AsciiFile_get_vector__SWIG_2(swigCPtr, SWIGTYPE_p_int.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_double vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.AsciiFile_get_vector__SWIG_3(swigCPtr, SWIGTYPE_p_double.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_float vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.AsciiFile_get_vector__SWIG_4(swigCPtr, SWIGTYPE_p_float.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_short vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.AsciiFile_get_vector__SWIG_5(swigCPtr, SWIGTYPE_p_short.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_unsigned_short vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.AsciiFile_get_vector__SWIG_6(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_matrix(SWIGTYPE_p_unsigned_char matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_matrix__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_matrix(string matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_matrix__SWIG_1(swigCPtr, matrix, SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_matrix(SWIGTYPE_p_int matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_matrix__SWIG_2(swigCPtr, SWIGTYPE_p_int.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_matrix(SWIGTYPE_p_float matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_matrix__SWIG_3(swigCPtr, SWIGTYPE_p_float.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_matrix(SWIGTYPE_p_double matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_matrix__SWIG_4(swigCPtr, SWIGTYPE_p_double.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_matrix(SWIGTYPE_p_short matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_matrix__SWIG_5(swigCPtr, SWIGTYPE_p_short.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_matrix(SWIGTYPE_p_unsigned_short matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_matrix__SWIG_6(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_ndarray(SWIGTYPE_p_unsigned_char array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.AsciiFile_get_ndarray__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_int8_ndarray(SWIGTYPE_p_signed_char array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.AsciiFile_get_int8_ndarray(swigCPtr, SWIGTYPE_p_signed_char.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_ndarray(string array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.AsciiFile_get_ndarray__SWIG_1(swigCPtr, array, SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_ndarray(SWIGTYPE_p_int array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.AsciiFile_get_ndarray__SWIG_2(swigCPtr, SWIGTYPE_p_int.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_uint_ndarray(SWIGTYPE_p_unsigned_int array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.AsciiFile_get_uint_ndarray(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_long_ndarray(SWIGTYPE_p_long_long array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.AsciiFile_get_long_ndarray(swigCPtr, SWIGTYPE_p_long_long.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_ulong_ndarray(SWIGTYPE_p_unsigned_long_long array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.AsciiFile_get_ulong_ndarray(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_ndarray(SWIGTYPE_p_float array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.AsciiFile_get_ndarray__SWIG_3(swigCPtr, SWIGTYPE_p_float.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_ndarray(SWIGTYPE_p_double array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.AsciiFile_get_ndarray__SWIG_4(swigCPtr, SWIGTYPE_p_double.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_longreal_ndarray(SWIGTYPE_p_long_double array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.AsciiFile_get_longreal_ndarray(swigCPtr, SWIGTYPE_p_long_double.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_ndarray(SWIGTYPE_p_short array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.AsciiFile_get_ndarray__SWIG_5(swigCPtr, SWIGTYPE_p_short.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_ndarray(SWIGTYPE_p_unsigned_short array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.AsciiFile_get_ndarray__SWIG_6(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_matrix(BoolSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_sparse_matrix__SWIG_0(swigCPtr, BoolSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_matrix(ByteSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_sparse_matrix__SWIG_1(swigCPtr, ByteSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_matrix(CharSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_sparse_matrix__SWIG_2(swigCPtr, CharSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_matrix(IntSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_sparse_matrix__SWIG_3(swigCPtr, IntSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_matrix(SWIGTYPE_p_shogun__SGSparseVectorT_short_t matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_sparse_matrix__SWIG_4(swigCPtr, SWIGTYPE_p_shogun__SGSparseVectorT_short_t.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_matrix(WordSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_sparse_matrix__SWIG_5(swigCPtr, WordSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_matrix(ShortRealSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_sparse_matrix__SWIG_6(swigCPtr, ShortRealSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_matrix(RealSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.AsciiFile_get_sparse_matrix__SWIG_7(swigCPtr, RealSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_list(SWIGTYPE_p_shogun__SGStringT_unsigned_char_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.AsciiFile_get_string_list__SWIG_0(swigCPtr, SWIGTYPE_p_shogun__SGStringT_unsigned_char_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_list(SWIGTYPE_p_shogun__SGStringT_char_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.AsciiFile_get_string_list__SWIG_1(swigCPtr, SWIGTYPE_p_shogun__SGStringT_char_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_list(SWIGTYPE_p_shogun__SGStringT_int_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.AsciiFile_get_string_list__SWIG_2(swigCPtr, SWIGTYPE_p_shogun__SGStringT_int_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_list(SWIGTYPE_p_shogun__SGStringT_short_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.AsciiFile_get_string_list__SWIG_3(swigCPtr, SWIGTYPE_p_shogun__SGStringT_short_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_list(SWIGTYPE_p_shogun__SGStringT_unsigned_short_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.AsciiFile_get_string_list__SWIG_4(swigCPtr, SWIGTYPE_p_shogun__SGStringT_unsigned_short_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_list(SWIGTYPE_p_shogun__SGStringT_float_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.AsciiFile_get_string_list__SWIG_5(swigCPtr, SWIGTYPE_p_shogun__SGStringT_float_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_list(SWIGTYPE_p_shogun__SGStringT_double_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.AsciiFile_get_string_list__SWIG_6(swigCPtr, SWIGTYPE_p_shogun__SGStringT_double_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_vector(SWIGTYPE_p_unsigned_char vector, int len) {
    modshogunPINVOKE.AsciiFile_set_vector__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(vector), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_vector(string vector, int len) {
    modshogunPINVOKE.AsciiFile_set_vector__SWIG_1(swigCPtr, vector, len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_vector(SWIGTYPE_p_int vector, int len) {
    modshogunPINVOKE.AsciiFile_set_vector__SWIG_2(swigCPtr, SWIGTYPE_p_int.getCPtr(vector), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_vector(SWIGTYPE_p_float vector, int len) {
    modshogunPINVOKE.AsciiFile_set_vector__SWIG_3(swigCPtr, SWIGTYPE_p_float.getCPtr(vector), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_vector(SWIGTYPE_p_double vector, int len) {
    modshogunPINVOKE.AsciiFile_set_vector__SWIG_4(swigCPtr, SWIGTYPE_p_double.getCPtr(vector), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_vector(SWIGTYPE_p_short vector, int len) {
    modshogunPINVOKE.AsciiFile_set_vector__SWIG_5(swigCPtr, SWIGTYPE_p_short.getCPtr(vector), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_vector(SWIGTYPE_p_unsigned_short vector, int len) {
    modshogunPINVOKE.AsciiFile_set_vector__SWIG_6(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(vector), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_matrix(SWIGTYPE_p_unsigned_char matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_matrix__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_matrix(string matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_matrix__SWIG_1(swigCPtr, matrix, num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_matrix(SWIGTYPE_p_int matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_matrix__SWIG_2(swigCPtr, SWIGTYPE_p_int.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_matrix(SWIGTYPE_p_float matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_matrix__SWIG_3(swigCPtr, SWIGTYPE_p_float.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_matrix(SWIGTYPE_p_double matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_matrix__SWIG_4(swigCPtr, SWIGTYPE_p_double.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_matrix(SWIGTYPE_p_short matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_matrix__SWIG_5(swigCPtr, SWIGTYPE_p_short.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_matrix(SWIGTYPE_p_unsigned_short matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_matrix__SWIG_6(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_ndarray(SWIGTYPE_p_unsigned_char array, SWIGTYPE_p_int dims, int num_dims) {
    modshogunPINVOKE.AsciiFile_set_ndarray__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), num_dims);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_int8_ndarray(SWIGTYPE_p_signed_char array, SWIGTYPE_p_int dims, int num_dims) {
    modshogunPINVOKE.AsciiFile_set_int8_ndarray(swigCPtr, SWIGTYPE_p_signed_char.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), num_dims);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_ndarray(string array, SWIGTYPE_p_int dims, int num_dims) {
    modshogunPINVOKE.AsciiFile_set_ndarray__SWIG_1(swigCPtr, array, SWIGTYPE_p_int.getCPtr(dims), num_dims);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_ndarray(SWIGTYPE_p_int array, SWIGTYPE_p_int dims, int num_dims) {
    modshogunPINVOKE.AsciiFile_set_ndarray__SWIG_2(swigCPtr, SWIGTYPE_p_int.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), num_dims);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_uint_ndarray(SWIGTYPE_p_unsigned_int array, SWIGTYPE_p_int dims, int num_dims) {
    modshogunPINVOKE.AsciiFile_set_uint_ndarray(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), num_dims);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_long_ndarray(SWIGTYPE_p_long_long array, SWIGTYPE_p_int dims, int num_dims) {
    modshogunPINVOKE.AsciiFile_set_long_ndarray(swigCPtr, SWIGTYPE_p_long_long.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), num_dims);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_ulong_ndarray(SWIGTYPE_p_unsigned_long_long array, SWIGTYPE_p_int dims, int num_dims) {
    modshogunPINVOKE.AsciiFile_set_ulong_ndarray(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), num_dims);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_ndarray(SWIGTYPE_p_float array, SWIGTYPE_p_int dims, int num_dims) {
    modshogunPINVOKE.AsciiFile_set_ndarray__SWIG_3(swigCPtr, SWIGTYPE_p_float.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), num_dims);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_ndarray(SWIGTYPE_p_double array, SWIGTYPE_p_int dims, int num_dims) {
    modshogunPINVOKE.AsciiFile_set_ndarray__SWIG_4(swigCPtr, SWIGTYPE_p_double.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), num_dims);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_longreal_ndarray(SWIGTYPE_p_long_double array, SWIGTYPE_p_int dims, int num_dims) {
    modshogunPINVOKE.AsciiFile_set_longreal_ndarray(swigCPtr, SWIGTYPE_p_long_double.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), num_dims);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_ndarray(SWIGTYPE_p_short array, SWIGTYPE_p_int dims, int num_dims) {
    modshogunPINVOKE.AsciiFile_set_ndarray__SWIG_5(swigCPtr, SWIGTYPE_p_short.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), num_dims);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_ndarray(SWIGTYPE_p_unsigned_short array, SWIGTYPE_p_int dims, int num_dims) {
    modshogunPINVOKE.AsciiFile_set_ndarray__SWIG_6(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), num_dims);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_sparse_matrix(BoolSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_sparse_matrix__SWIG_0(swigCPtr, BoolSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_sparse_matrix(ByteSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_sparse_matrix__SWIG_1(swigCPtr, ByteSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_sparse_matrix(CharSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_sparse_matrix__SWIG_2(swigCPtr, CharSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_sparse_matrix(IntSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_sparse_matrix__SWIG_3(swigCPtr, IntSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_sparse_matrix(SWIGTYPE_p_shogun__SGSparseVectorT_short_t matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_sparse_matrix__SWIG_4(swigCPtr, SWIGTYPE_p_shogun__SGSparseVectorT_short_t.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_sparse_matrix(WordSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_sparse_matrix__SWIG_5(swigCPtr, WordSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_sparse_matrix(ShortRealSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_sparse_matrix__SWIG_6(swigCPtr, ShortRealSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_sparse_matrix(RealSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.AsciiFile_set_sparse_matrix__SWIG_7(swigCPtr, RealSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_string_list(SWIGTYPE_p_shogun__SGStringT_unsigned_char_t strings, int num_str) {
    modshogunPINVOKE.AsciiFile_set_string_list__SWIG_0(swigCPtr, SWIGTYPE_p_shogun__SGStringT_unsigned_char_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_string_list(SWIGTYPE_p_shogun__SGStringT_char_t strings, int num_str) {
    modshogunPINVOKE.AsciiFile_set_string_list__SWIG_1(swigCPtr, SWIGTYPE_p_shogun__SGStringT_char_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_string_list(SWIGTYPE_p_shogun__SGStringT_int_t strings, int num_str) {
    modshogunPINVOKE.AsciiFile_set_string_list__SWIG_2(swigCPtr, SWIGTYPE_p_shogun__SGStringT_int_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_string_list(SWIGTYPE_p_shogun__SGStringT_short_t strings, int num_str) {
    modshogunPINVOKE.AsciiFile_set_string_list__SWIG_3(swigCPtr, SWIGTYPE_p_shogun__SGStringT_short_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_string_list(SWIGTYPE_p_shogun__SGStringT_unsigned_short_t strings, int num_str) {
    modshogunPINVOKE.AsciiFile_set_string_list__SWIG_4(swigCPtr, SWIGTYPE_p_shogun__SGStringT_unsigned_short_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_string_list(SWIGTYPE_p_shogun__SGStringT_float_t strings, int num_str) {
    modshogunPINVOKE.AsciiFile_set_string_list__SWIG_5(swigCPtr, SWIGTYPE_p_shogun__SGStringT_float_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void set_string_list(SWIGTYPE_p_shogun__SGStringT_double_t strings, int num_str) {
    modshogunPINVOKE.AsciiFile_set_string_list__SWIG_6(swigCPtr, SWIGTYPE_p_shogun__SGStringT_double_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public static SWIGTYPE_p_ssize_t getdelim(SWIGTYPE_p_p_char lineptr, SWIGTYPE_p_size_t n, char delimiter, SWIGTYPE_p_FILE stream) {
    SWIGTYPE_p_ssize_t ret = new SWIGTYPE_p_ssize_t(modshogunPINVOKE.AsciiFile_getdelim(SWIGTYPE_p_p_char.getCPtr(lineptr), SWIGTYPE_p_size_t.getCPtr(n), delimiter, SWIGTYPE_p_FILE.getCPtr(stream)), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_ssize_t getline(SWIGTYPE_p_p_char lineptr, SWIGTYPE_p_size_t n, SWIGTYPE_p_FILE stream) {
    SWIGTYPE_p_ssize_t ret = new SWIGTYPE_p_ssize_t(modshogunPINVOKE.AsciiFile_getline(SWIGTYPE_p_p_char.getCPtr(lineptr), SWIGTYPE_p_size_t.getCPtr(n), SWIGTYPE_p_FILE.getCPtr(stream)), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void tokenize(char delim, SWIGTYPE_p_shogun__substring s, SWIGTYPE_p_v_arrayT_shogun__substring_t ret) {
    modshogunPINVOKE.AsciiFile_tokenize(delim, SWIGTYPE_p_shogun__substring.getCPtr(s), SWIGTYPE_p_v_arrayT_shogun__substring_t.getCPtr(ret));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
