/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Labels : SGObject {
  private HandleRef swigCPtr;

  internal Labels(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.LabelsUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Labels obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Labels() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_Labels(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Labels() : this(modshogunPINVOKE.new_Labels__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public Labels(int num_labels) : this(modshogunPINVOKE.new_Labels__SWIG_1(num_labels), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public Labels(double[] src) : this(modshogunPINVOKE.new_Labels__SWIG_2(src.Length, src), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public Labels(File loader) : this(modshogunPINVOKE.new_Labels__SWIG_3(File.getCPtr(loader)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void load(File loader) {
    modshogunPINVOKE.Labels_load(swigCPtr, File.getCPtr(loader));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void save(File writer) {
    modshogunPINVOKE.Labels_save(swigCPtr, File.getCPtr(writer));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool set_label(int idx, double label) {
    bool ret = modshogunPINVOKE.Labels_set_label(swigCPtr, idx, label);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_int_label(int idx, int label) {
    bool ret = modshogunPINVOKE.Labels_set_int_label(swigCPtr, idx, label);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_label(int idx) {
    double ret = modshogunPINVOKE.Labels_get_label(swigCPtr, idx);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_int_label(int idx) {
    int ret = modshogunPINVOKE.Labels_get_int_label(swigCPtr, idx);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool is_two_class_labeling() {
    bool ret = modshogunPINVOKE.Labels_is_two_class_labeling(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_num_classes() {
    int ret = modshogunPINVOKE.Labels_get_num_classes(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double[] get_labels() {
		IntPtr ptr = modshogunPINVOKE.Labels_get_labels(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		double[] ret = new double[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public void set_labels(double[] v) {
    modshogunPINVOKE.Labels_set_labels(swigCPtr, v.Length, v);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_to_one() {
    modshogunPINVOKE.Labels_set_to_one(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int[] get_int_labels() {
		IntPtr ptr = modshogunPINVOKE.Labels_get_int_labels(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		int[] ret = new int[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public double[] get_classes() {
		IntPtr ptr = modshogunPINVOKE.Labels_get_classes(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		double[] ret = new double[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public void set_int_labels(int[] labels) {
    modshogunPINVOKE.Labels_set_int_labels(swigCPtr, labels.Length, labels);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_num_labels() {
    int ret = modshogunPINVOKE.Labels_get_num_labels(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_subset(SWIGTYPE_p_CSubset subset) {
    modshogunPINVOKE.Labels_set_subset(swigCPtr, SWIGTYPE_p_CSubset.getCPtr(subset));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void remove_subset() {
    modshogunPINVOKE.Labels_remove_subset(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int subset_idx_conversion(int idx) {
    int ret = modshogunPINVOKE.Labels_subset_idx_conversion(swigCPtr, idx);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}