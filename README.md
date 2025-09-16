# MailingListSignUp for Unity Game Engine
This is a no-code Unity asset for integrating MailerLite with Unity to build an email list.
The Mailing List Signup Asset is a prefab for adding subscribers to a Mailer Lite mailing list. It is an integration with Mailer Lite’s API which makes audience building easy for Unity game developers.
<img width="1080" height="1080" alt="1_MailerLite Unity Package Slides" src="https://github.com/user-attachments/assets/c2ada5af-9bda-44af-8ddd-0b8a7b1fa3ca" />

# How to use
- In [MailerLite](https://www.mailerlite.com/)
  - Set up an account (it’s free)  
  - Create a new API Key
  - Optional: Create Group(s) and copy the Group ID(s)
- In Unity
  - Import the [package](https://drive.google.com/file/d/15r0FwAE4vjlHpvKIUMFIjCtpaZBj0ToY/view?usp=drive_link) 
  - Create a new scene
  - Drag the SignUpFormCanvas prefab onto your scene from the Project menu. It is located in Assets/WafunkPublishing/MailingListSignUp/Prefabs
  - Create an empty Game object – your controller - and attach the SignUpScript.cs file to it. It is located in Assets/WafunkPublishing/MailingListSignUp/Scripts
  - Paste your MailerLite API Key into the ApiKeyInputField of the SignUpFormCanvas. Not to worry, it gets hidden when the app is run.
  - Select your controller and drag the NameInputField, EmailInputField, ApiKeyInputField, TermsButton and AlertPanel from the SignUpFormCanvas into the appropriate holders in the Inspector View
  - If you have a Menu Scene or any other scene you'd like to navigate to after a user successfully registers or skips registration, enter its name in the 'Menu Scene' field in the Inspector View
  - If you have Group you'd like your signups to be automatically added to then add the group ID(s) to the Group Id List field by clicking the '+' icons
  - Select the 'SkipButton' from the SignUpFormCanvas and set its click method to the 'SignUpScript.SkipRegistration' function
  - Select the 'SubmitButton' from the SignUpFormCanvas and set its click method to the 'SignUpScript.Register' function
  - Select the 'TermsAndConditionsButton' from the SignUpFormCanvas and set its click method to the 'SignUpScript.TermsChecked' function
  - You may also want to edit the TermsAndConditionsText text in the Inspector
- Run the scene to test

# Demo Scene
The DemoScene shows the asset in use. Note that the API Key is currently a dummy one so ensure you replace it with yours as described above. 
See below a step-by-step guide of how to import the package and test using the Demo Scene

<img width="1080" height="1080" alt="2_MailerLite Unity Package Slides" src="https://github.com/user-attachments/assets/3716cdd6-f6ac-497d-a16e-1a9e9fd3ece1" />
<img width="1080" height="1080" alt="3_MailerLite Unity Package Slides" src="https://github.com/user-attachments/assets/62f9ed14-cf32-41c8-9f3d-68b0c62e18fd" />
<img width="1080" height="1080" alt="4_MailerLite Unity Package Slides" src="https://github.com/user-attachments/assets/05bce14f-be60-42ef-a2a8-25f95347ad7a" />
<img width="1080" height="1080" alt="5_MailerLite Unity Package Slides" src="https://github.com/user-attachments/assets/d87acd8a-0295-43b7-9d75-543b03a74b42" />
<img width="1080" height="1080" alt="6_MailerLite Unity Package Slides" src="https://github.com/user-attachments/assets/804fb96b-6d02-4ebf-97f7-cf55aa8a6db9" />
<img width="1080" height="1080" alt="7_MailerLite Unity Package Slides" src="https://github.com/user-attachments/assets/3ac575f8-f8ab-4aad-b9c6-c0aed02643f4" />
<img width="1080" height="1080" alt="8_MailerLite Unity Package Slides" src="https://github.com/user-attachments/assets/71fa9bf3-6ec9-4945-9680-f43dd28d3bc2" />
<img width="1080" height="1080" alt="9_MailerLite Unity Package Slides" src="https://github.com/user-attachments/assets/b710c0da-45f1-4eb6-9247-e5a8ec2f9422" />
