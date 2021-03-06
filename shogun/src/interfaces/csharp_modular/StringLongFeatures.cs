/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class StringLongFeatures : Features {
  private HandleRef swigCPtr;

  internal StringLongFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.StringLongFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StringLongFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StringLongFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_StringLongFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public StringLongFeatures() : this(modshogunPINVOKE.new_StringLongFeatures__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringLongFeatures(EAlphabet alpha) : this(modshogunPINVOKE.new_StringLongFeatures__SWIG_1((int)alpha), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringLongFeatures(long[,] string_list, EAlphabet alpha) : this(modshogunPINVOKE.new_StringLongFeatures__SWIG_2(string_list.GetLength(0), string_list.GetLength(1), string_list, (int)alpha), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringLongFeatures(long[,] string_list, Alphabet alpha) : this(modshogunPINVOKE.new_StringLongFeatures__SWIG_3(string_list.GetLength(0), string_list.GetLength(1), string_list, Alphabet.getCPtr(alpha)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringLongFeatures(Alphabet alpha) : this(modshogunPINVOKE.new_StringLongFeatures__SWIG_4(Alphabet.getCPtr(alpha)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringLongFeatures(StringLongFeatures orig) : this(modshogunPINVOKE.new_StringLongFeatures__SWIG_5(StringLongFeatures.getCPtr(orig)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringLongFeatures(File loader, EAlphabet alpha) : this(modshogunPINVOKE.new_StringLongFeatures__SWIG_6(File.getCPtr(loader), (int)alpha), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringLongFeatures(File loader) : this(modshogunPINVOKE.new_StringLongFeatures__SWIG_7(File.getCPtr(loader)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void cleanup_feature_vector(int num) {
    modshogunPINVOKE.StringLongFeatures_cleanup_feature_vector(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void cleanup_feature_vectors(int start, int stop) {
    modshogunPINVOKE.StringLongFeatures_cleanup_feature_vectors(swigCPtr, start, stop);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public Alphabet get_alphabet() {
    IntPtr cPtr = modshogunPINVOKE.StringLongFeatures_get_alphabet(swigCPtr);
    Alphabet ret = (cPtr == IntPtr.Zero) ? null : new Alphabet(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long[] get_feature_vector(int num) {
		IntPtr ptr = modshogunPINVOKE.StringLongFeatures_get_feature_vector(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		long[] ret = new long[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public void set_feature_vector(long[] vector, int num) {
    modshogunPINVOKE.StringLongFeatures_set_feature_vector(swigCPtr, vector.Length, vector, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void enable_on_the_fly_preprocessing() {
    modshogunPINVOKE.StringLongFeatures_enable_on_the_fly_preprocessing(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void disable_on_the_fly_preprocessing() {
    modshogunPINVOKE.StringLongFeatures_disable_on_the_fly_preprocessing(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringLongFeatures get_transposed() {
    IntPtr cPtr = modshogunPINVOKE.StringLongFeatures_get_transposed(swigCPtr);
    StringLongFeatures ret = (cPtr == IntPtr.Zero) ? null : new StringLongFeatures(cPtr, true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual long get_feature(int vec_num, int feat_num) {
    long ret = modshogunPINVOKE.StringLongFeatures_get_feature(swigCPtr, vec_num, feat_num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int get_vector_length(int vec_num) {
    int ret = modshogunPINVOKE.StringLongFeatures_get_vector_length(swigCPtr, vec_num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int get_max_vector_length() {
    int ret = modshogunPINVOKE.StringLongFeatures_get_max_vector_length(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_long_double get_num_symbols() {
    SWIGTYPE_p_long_double ret = new SWIGTYPE_p_long_double(modshogunPINVOKE.StringLongFeatures_get_num_symbols(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_long_double get_max_num_symbols() {
    SWIGTYPE_p_long_double ret = new SWIGTYPE_p_long_double(modshogunPINVOKE.StringLongFeatures_get_max_num_symbols(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_long_double get_original_num_symbols() {
    SWIGTYPE_p_long_double ret = new SWIGTYPE_p_long_double(modshogunPINVOKE.StringLongFeatures_get_original_num_symbols(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_order() {
    int ret = modshogunPINVOKE.StringLongFeatures_get_order(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long get_masked_symbols(long symbol, byte mask) {
    long ret = modshogunPINVOKE.StringLongFeatures_get_masked_symbols(swigCPtr, symbol, mask);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long shift_offset(long offset, int amount) {
    long ret = modshogunPINVOKE.StringLongFeatures_shift_offset(swigCPtr, offset, amount);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long shift_symbol(long symbol, int amount) {
    long ret = modshogunPINVOKE.StringLongFeatures_shift_symbol(swigCPtr, symbol, amount);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void load_ascii_file(string fname, bool remap_to_bin, EAlphabet ascii_alphabet, EAlphabet binary_alphabet) {
    modshogunPINVOKE.StringLongFeatures_load_ascii_file__SWIG_0(swigCPtr, fname, remap_to_bin, (int)ascii_alphabet, (int)binary_alphabet);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void load_ascii_file(string fname, bool remap_to_bin, EAlphabet ascii_alphabet) {
    modshogunPINVOKE.StringLongFeatures_load_ascii_file__SWIG_1(swigCPtr, fname, remap_to_bin, (int)ascii_alphabet);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void load_ascii_file(string fname, bool remap_to_bin) {
    modshogunPINVOKE.StringLongFeatures_load_ascii_file__SWIG_2(swigCPtr, fname, remap_to_bin);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void load_ascii_file(string fname) {
    modshogunPINVOKE.StringLongFeatures_load_ascii_file__SWIG_3(swigCPtr, fname);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool load_fasta_file(string fname, bool ignore_invalid) {
    bool ret = modshogunPINVOKE.StringLongFeatures_load_fasta_file__SWIG_0(swigCPtr, fname, ignore_invalid);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_fasta_file(string fname) {
    bool ret = modshogunPINVOKE.StringLongFeatures_load_fasta_file__SWIG_1(swigCPtr, fname);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_fastq_file(string fname, bool ignore_invalid, bool bitremap_in_single_string) {
    bool ret = modshogunPINVOKE.StringLongFeatures_load_fastq_file__SWIG_0(swigCPtr, fname, ignore_invalid, bitremap_in_single_string);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_fastq_file(string fname, bool ignore_invalid) {
    bool ret = modshogunPINVOKE.StringLongFeatures_load_fastq_file__SWIG_1(swigCPtr, fname, ignore_invalid);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_fastq_file(string fname) {
    bool ret = modshogunPINVOKE.StringLongFeatures_load_fastq_file__SWIG_2(swigCPtr, fname);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_from_directory(string dirname) {
    bool ret = modshogunPINVOKE.StringLongFeatures_load_from_directory(swigCPtr, dirname);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_features(long[,] feats) {
    modshogunPINVOKE.StringLongFeatures_set_features(swigCPtr, feats.GetLength(0), feats.GetLength(1), feats);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool append_features(StringLongFeatures sf) {
    bool ret = modshogunPINVOKE.StringLongFeatures_append_features(swigCPtr, StringLongFeatures.getCPtr(sf));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long[,] get_features() {
	IntPtr ptr = modshogunPINVOKE.StringLongFeatures_get_features(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
	long[] ranks = new long[2];
	Marshal.Copy(ptr, ranks, 0, 2);

	int rows = (int)ranks[0];
	int cols = (int)ranks[1];
	int len = rows * cols;

	long[] ret = new long[len];

	Marshal.Copy(new IntPtr(ptr.ToInt64() + 2 * Marshal.SizeOf(typeof(long))), ret, 0, len);

	long[,] result = new long[rows, cols];
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < cols; j++) {
			result[i, j] = ret[i * cols + j];
		}
	}
	return result;
}

  public virtual bool load_compressed(string src, bool decompress) {
    bool ret = modshogunPINVOKE.StringLongFeatures_load_compressed(swigCPtr, src, decompress);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool save_compressed(string dest, E_COMPRESSION_TYPE compression, int level) {
    bool ret = modshogunPINVOKE.StringLongFeatures_save_compressed(swigCPtr, dest, (int)compression, level);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool apply_preprocessor(bool force_preprocessing) {
    bool ret = modshogunPINVOKE.StringLongFeatures_apply_preprocessor__SWIG_0(swigCPtr, force_preprocessing);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool apply_preprocessor() {
    bool ret = modshogunPINVOKE.StringLongFeatures_apply_preprocessor__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int obtain_by_sliding_window(int window_size, int step_size, int skip) {
    int ret = modshogunPINVOKE.StringLongFeatures_obtain_by_sliding_window__SWIG_0(swigCPtr, window_size, step_size, skip);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int obtain_by_sliding_window(int window_size, int step_size) {
    int ret = modshogunPINVOKE.StringLongFeatures_obtain_by_sliding_window__SWIG_1(swigCPtr, window_size, step_size);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int obtain_by_position_list(int window_size, DynamicIntArray positions, int skip) {
    int ret = modshogunPINVOKE.StringLongFeatures_obtain_by_position_list__SWIG_0(swigCPtr, window_size, DynamicIntArray.getCPtr(positions), skip);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int obtain_by_position_list(int window_size, DynamicIntArray positions) {
    int ret = modshogunPINVOKE.StringLongFeatures_obtain_by_position_list__SWIG_1(swigCPtr, window_size, DynamicIntArray.getCPtr(positions));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool obtain_from_char(StringCharFeatures sf, int start, int p_order, int gap, bool rev) {
    bool ret = modshogunPINVOKE.StringLongFeatures_obtain_from_char(swigCPtr, StringCharFeatures.getCPtr(sf), start, p_order, gap, rev);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool have_same_length(int len) {
    bool ret = modshogunPINVOKE.StringLongFeatures_have_same_length__SWIG_0(swigCPtr, len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool have_same_length() {
    bool ret = modshogunPINVOKE.StringLongFeatures_have_same_length__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void embed_features(int p_order) {
    modshogunPINVOKE.StringLongFeatures_embed_features(swigCPtr, p_order);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void compute_symbol_mask_table(long max_val) {
    modshogunPINVOKE.StringLongFeatures_compute_symbol_mask_table(swigCPtr, max_val);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void determine_maximum_string_length() {
    modshogunPINVOKE.StringLongFeatures_determine_maximum_string_length(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
