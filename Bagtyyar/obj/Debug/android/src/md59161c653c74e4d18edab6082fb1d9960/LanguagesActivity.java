package md59161c653c74e4d18edab6082fb1d9960;


public class LanguagesActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Bagtyyar.LanguagesActivity, Bagtyyar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LanguagesActivity.class, __md_methods);
	}


	public LanguagesActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LanguagesActivity.class)
			mono.android.TypeManager.Activate ("Bagtyyar.LanguagesActivity, Bagtyyar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
