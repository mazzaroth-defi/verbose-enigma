# verbose-enigma
Emotion Tracker built with blazor.

# EF 
1. CD to infrastructure project and run `dotnet add package Microsoft.EntityFrameworkCore.Design`.
2. CD to `src/EmotionTracker/Server/` and run the command below.

```
dotnet ef database update --context BlazorHeroContext -v
```
