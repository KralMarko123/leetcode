# LeetCode Solutions

This repository is a small personal LeetCode workspace. It keeps the C# solution files in one place and pairs them with a lightweight React frontend for browsing problems, reading the approach notes, and reviewing the final code.

The goal is not to be a full competitive-programming platform. It is a cleaner reference library: each problem has a description, a short explanation of the idea behind the solution, a link back to LeetCode, and the implementation used in the C# project.

## Repository Layout

- `backend/` contains the .NET solution project with the C# implementations grouped by difficulty.
- `frontend/` contains the React app that presents the problem list and solution details.
- `Leetcode.sln` is the root solution file used to build the C# project.

## Running The Frontend

Install the frontend dependencies and start the development server:

```powershell
cd frontend
npm install
npm start
```

Create a production build with:

```powershell
cd frontend
npm run build
```

The frontend is configured for GitHub Pages deployment through the `deploy` script.

## Building The C# Project

From the repository root:

```powershell
dotnet build Leetcode.sln
```

## Adding A New Problem

1. Add the C# implementation under the matching difficulty folder in `backend/Leetcode.Exercises.CSharp/`.
2. Add the frontend metadata in `frontend/src/constants/`, including the problem entry, description, approach, LeetCode link, and code snippet.
3. Run the frontend locally and confirm the new solution appears in the list and details page.
