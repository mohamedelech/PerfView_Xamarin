# PerfView_Xamarin

Mise en place :

Ce projet a était développé à l'aide de l'environnement de travail Visual Studio 2017
Pour ce faire si vous n'avez pas cette IDE il va falloir l'installer :https://developer.xamarin.com/guides/android/getting_started/installation/windows/#installation
N'oubliez pas d'installer l'extension Xamarin.

Si Visual Studio 2017 est déjà installé,
vous pouvez ajouter Xamarin via "Visual Studio installer": https://docs.microsoft.com/en-us/visualstudio/install/modify-visual-studio

Si vous avez déjà Visual Studio 2015 ou 2013,
vous pouvez également ajouter Xamarin : https://developer.xamarin.com/guides/android/getting_started/installation/windows/#Adding_Xamarin_to_Visual_Studio_2015_or_2013

Une fois Visual Studio installé,
Xamarin.Android utilise Java JDK et le SDK d'Android pour créer des applications.
Pendant l'installation, le programme d'installation de Visual Studio place ces outils dans leurs emplacements par défaut
et configure l'environnement de développement : https://developer.xamarin.com/guides/android/getting_started/installation/windows/#Configuration

Etapes déjà effectuées si vous l'avez deja fait avec Android Studio.
      Si vous n'avez pas d'appareil Android physique à utiliser pour tester,
      vous pouvez utiliser un émulateur Android pour tester votre application.
      Pour plus d'informations sur la configuration et l'utilisation de l'émulateur Google Android,
      consultez l'Emulateur SDK Android : https://developer.xamarin.com/guides/android/deployment,_testing,_and_metrics/debug-on-emulator/android-sdk-emulator/

      Si vous avez un appareil Android physique,
      configurez votre périphérique pour le développement,
      puis connectez le à votre ordinateur pour exécuter et déboguer les applications Xamarin.Android : https://developer.xamarin.com/guides/android/getting_started/installation/set_up_device_for_development/
      je vous conseil cette approche car les émulateurs sont très long.
      
Finalement, pour déployer le projet :
- Télécharger le zip du projet depuis github
- Dézipper le projet (évitez de le placer dans un emplacement où le chemin d'accès est long)
- Ouvrir Visual Studio et importez la solution/projet. 
     cliquez sur "Fichier" puis sur "Ouvrir" et finalement "Projet/Solution".
     Selectionnez la solution "Perf View Xamarin.sln" et non pas le dossier.
