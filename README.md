This repository is a demo of the process of upgrading a sample Xamarin application to Xamarin 5.

I've encountered a variety of errors while attempting to update a freshly-created Xamarin application to Xamarin 5. Interestingly enough, the only error that still reproduces for me is this error:

  Attribute application@appComponentFactory value=(android.support.v4.app.CoreComponentFactory) is also present at AndroidManifest.xml:24:18-86 value=(androidx.core.app.CoreComponentFactory).

which can be fixed by cleaning the project, but cleaning the project shouldn't be necessary.


To reproduce:

Check out the Xamarin 4 commit and deploy it to an Android phone, and see that it works
Check out master (which updates to Xamarin 5) and see that when trying to deploy it to an Android phone causes the above build failure (until you clean the project)
