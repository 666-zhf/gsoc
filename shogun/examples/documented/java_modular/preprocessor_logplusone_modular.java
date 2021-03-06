// In this example a kernel matrix is computed for a given real-valued data set.
// The kernel used is the Chi2 kernel which operates on real-valued vectors. It
// computes the chi-squared distance between sets of histograms. It is a very
// useful distance in image recognition (used to detect objects). The preprocessor
// LogPlusOne adds one to a dense real-valued vector and takes the logarithm of
// each component of it. It is most useful in situations where the inputs are
// counts: When one compares differences of small counts any difference may matter
// a lot, while small differences in large counts don't. This is what this log
// transformation controls for.

import org.shogun.*;
import org.jblas.*;

public class preprocessor_logplusone_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();
		double width = 1.4;
		int size_cache = 10;

		DoubleMatrix traindata_real = Load.load_numbers("../data/fm_train_real.dat");
		DoubleMatrix testdata_real = Load.load_numbers("../data/fm_test_real.dat");

		RealFeatures feats_train = new RealFeatures(traindata_real);
		RealFeatures feats_test = new RealFeatures(testdata_real);

		LogPlusOne preproc = new LogPlusOne();
		preproc.init(feats_train);
		feats_train.add_preprocessor(preproc);
		feats_train.apply_preprocessor();
		feats_test.add_preprocessor(preproc);
		feats_test.apply_preprocessor();

	
		Chi2Kernel kernel = new Chi2Kernel(feats_train, feats_train, width, size_cache);

		DoubleMatrix km_train = kernel.get_kernel_matrix();
		kernel.init(feats_train, feats_test);
		DoubleMatrix km_test = kernel.get_kernel_matrix();

		System.out.println(km_train.toString());
		System.out.println(km_test.toString());

		modshogun.exit_shogun();
	}
}
