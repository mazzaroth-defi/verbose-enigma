# verbose-enigma
Emotion Tracker built with blazor.

# EF 
## Getting Started
1. CD to infrastructure project and run `dotnet add package Microsoft.EntityFrameworkCore.Design`.
2. CD to `src/EmotionTracker/Server/` and run the commands below.

## Add Migration
### Mac (Work in Progress)
This is what worked for BlazorBoilerplate, but it does not work on a Mac because microsoft is unable to retrieve project metadata.

```
Open up package manager console
CD to Server/BlazorBoilerplate.Storage
Set default project to BB.Server
Run: dotnet ef --startup-project ../BlazorBoilerplate.Server/ migrations add Add-Migration -c ApplicationDbContext --verbose --no-build --configuration Debug
Check the migration was created correctly.
Run db update command: dotnet ef --startup-project ../BlazorBoilerplate.Server/ database update -c ApplicationDbContext --verbose --no-build --configuration Debug
```

#### 1
Directory: EmotionTracker.Infrastructure
Command: dotnet ef migrations add Add-Emotion-Objects -c BlazorHeroContext -v -p EmotionTracker.Infrastructure.csproj
Error: Unable to create an object of type 'BlazorHeroContext'. For the different patterns supported at design time, see https://go.microsoft.com/fwlink/?linkid=851728

#### 2
Directory: EmotionTracker.Infrastructure
Command: dotnet ef migrations add Add-Emotion-Objects -c BlazorHeroContext -v --startup-project ../EmotionTracker/Server/EmotiontTracker.Server.csproj
Error: Unable to retrieve project metadata. Ensure it's an SDK-style project. If you're using a custom BaseIntermediateOutputPath or MSBuildProjectExtensionsPath values, Use the --msbuildprojectextensionspath option.


```
dotnet ef database update --context BlazorHeroContext -v
```

## Update Database
```
dotnet ef migrations add <MigrationName> --context BlazorHeroContext -v
```

# Emotion Wheel Description

Source: [https://imgur.com/gallery/tCWChf6](https://imgur.com/gallery/tCWChf6)

This is the updated version (original here - http://imgur.com/q6hcgsH) with more saturated colours and a few fixed typos. Spelling is correct for American English. The Australian English version can be found here - http://imgur.com/a/CkxQC

A wheel of emotional words.

I work with people who have limited emotional vocabulary and as a result the intensity of their negative emotions and experiences is heightened because they can't describe their feelings (especially their negative feelings). That's why this list is heavily focused on negative emotions/ experiences. Being able to clearly identify how we are feeling has been shown to reduce this intensity of experience because it re-engages our rational mind.

I believe the first application of an emotion wheel in this style was from Dr. Gloria Willcox back in the early 80’s. The wheel I put together is much more comprehensive than her original wheeI although I suspect she had a more studious approach. It’s possible the wheel I originally based mine on was created by a teacher named Kaitlin Robb, although I think her wheel is also an updated version of the earlier one I found circulating the internet.

If you're looking to license or reproduce my Emotional Word Wheel (especially if you want the most up to date version) you can contact me (Geoffrey Roberts) via my work Facebook page, www.facebook.com/thewhitehousechurch

Not for Profit use is encouraged, send me a message if you want the high resolution image. I'm keen to hear how people are using it!

![Alt text](https://i.imgur.com/tCWChf6.jpeg)


# Emotions
## Happy: 
* Playful
  * Aroused
  * Cheeky
  * Free
  * Joyful
  * Curious
  * Inquisitive
  * Successful
  * Confident
  * Respected
  * Valued
  * Courageous
  * Creative
  * Loving
  * Thankful
  * Sensitive
  * Intimate
  * Hopeful
  * Inspired


## Surprised
## Bad
## Fearful

## Angry
* Let Down
  * Betrayed: 
  * Resentful: 
* Humiliated: 
  * Disrespected: 
  * Ridiculed: 
* Bitter: 
  * Indignant: 
  * Violated
* Mad
  * Furious
  * Jealous
* Aggressive
  * Provoked
  * Hostile
* Frustrated
  * Infuriated
  * Annoyed
* Distant
  * Withdrawn
  * Numb
* Critical
  * Sceptical
  * Dismissive

## Disgusted: 
* Disapproving
  * Judgmental
  * Embarrassed
* Disappointed
  * Appalled
  * Revolted
* Awful
  * Nauseated
  * Detestable
* Repelled
  * Horrified
  * Hesitant



## Sad
