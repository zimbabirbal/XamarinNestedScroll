package md55654edf9515f92854d0924d44f83107d;


public class NestedScrollDroid
	extends md51558244f76c53b6aeda52c8a337f2c37.ListViewRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("NestedScrollTest.Droid.CustomRendererDroid.NestedScrollDroid, NestedScrollTest.Android", NestedScrollDroid.class, __md_methods);
	}


	public NestedScrollDroid (android.content.Context p0)
	{
		super (p0);
		if (getClass () == NestedScrollDroid.class)
			mono.android.TypeManager.Activate ("NestedScrollTest.Droid.CustomRendererDroid.NestedScrollDroid, NestedScrollTest.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public NestedScrollDroid (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == NestedScrollDroid.class)
			mono.android.TypeManager.Activate ("NestedScrollTest.Droid.CustomRendererDroid.NestedScrollDroid, NestedScrollTest.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public NestedScrollDroid (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == NestedScrollDroid.class)
			mono.android.TypeManager.Activate ("NestedScrollTest.Droid.CustomRendererDroid.NestedScrollDroid, NestedScrollTest.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
