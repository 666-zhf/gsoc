/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ShortRealSparseMatrix : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ShortRealSparseMatrix(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ShortRealSparseMatrix obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ShortRealSparseMatrix() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_ShortRealSparseMatrix(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ShortRealSparseMatrix() : this(modshogunPINVOKE.new_ShortRealSparseMatrix__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ShortRealSparseMatrix(ShortRealSparseVector vecs, int num_feat, int num_vec, bool free_m) : this(modshogunPINVOKE.new_ShortRealSparseMatrix__SWIG_1(ShortRealSparseVector.getCPtr(vecs), num_feat, num_vec, free_m), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ShortRealSparseMatrix(ShortRealSparseVector vecs, int num_feat, int num_vec) : this(modshogunPINVOKE.new_ShortRealSparseMatrix__SWIG_2(ShortRealSparseVector.getCPtr(vecs), num_feat, num_vec), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ShortRealSparseMatrix(int num_vec, int num_feat, bool free_m) : this(modshogunPINVOKE.new_ShortRealSparseMatrix__SWIG_3(num_vec, num_feat, free_m), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ShortRealSparseMatrix(int num_vec, int num_feat) : this(modshogunPINVOKE.new_ShortRealSparseMatrix__SWIG_4(num_vec, num_feat), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ShortRealSparseMatrix(ShortRealSparseMatrix orig) : this(modshogunPINVOKE.new_ShortRealSparseMatrix__SWIG_5(ShortRealSparseMatrix.getCPtr(orig)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void free_matrix() {
    modshogunPINVOKE.ShortRealSparseMatrix_free_matrix(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void own_matrix() {
    modshogunPINVOKE.ShortRealSparseMatrix_own_matrix(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void destroy_matrix() {
    modshogunPINVOKE.ShortRealSparseMatrix_destroy_matrix(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int num_vectors {
    set {
      modshogunPINVOKE.ShortRealSparseMatrix_num_vectors_set(swigCPtr, value);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = modshogunPINVOKE.ShortRealSparseMatrix_num_vectors_get(swigCPtr);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int num_features {
    set {
      modshogunPINVOKE.ShortRealSparseMatrix_num_features_set(swigCPtr, value);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = modshogunPINVOKE.ShortRealSparseMatrix_num_features_get(swigCPtr);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ShortRealSparseVector sparse_matrix {
    set {
      modshogunPINVOKE.ShortRealSparseMatrix_sparse_matrix_set(swigCPtr, ShortRealSparseVector.getCPtr(value));
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = modshogunPINVOKE.ShortRealSparseMatrix_sparse_matrix_get(swigCPtr);
      ShortRealSparseVector ret = (cPtr == IntPtr.Zero) ? null : new ShortRealSparseVector(cPtr, false);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool do_free {
    set {
      modshogunPINVOKE.ShortRealSparseMatrix_do_free_set(swigCPtr, value);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = modshogunPINVOKE.ShortRealSparseMatrix_do_free_get(swigCPtr);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool save_serializable(SerializableFile file, string prefix) {
    bool ret = modshogunPINVOKE.ShortRealSparseMatrix_save_serializable__SWIG_0(swigCPtr, SerializableFile.getCPtr(file), prefix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_serializable(SerializableFile file) {
    bool ret = modshogunPINVOKE.ShortRealSparseMatrix_save_serializable__SWIG_1(swigCPtr, SerializableFile.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_serializable(SerializableFile file, string prefix) {
    bool ret = modshogunPINVOKE.ShortRealSparseMatrix_load_serializable__SWIG_0(swigCPtr, SerializableFile.getCPtr(file), prefix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_serializable(SerializableFile file) {
    bool ret = modshogunPINVOKE.ShortRealSparseMatrix_load_serializable__SWIG_1(swigCPtr, SerializableFile.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
