import js from "@eslint/js";
import globals from "globals";
import pluginReact from "eslint-plugin-react";
import { defineConfig, globalIgnores } from "eslint/config";
import exampleConfig from "eslint-config-example";

export default defineConfig([
  { 
    files: ["**/*.{js,mjs,cjs,jsx}"], 
    
    "rules": {
        "no-unused-vars": ["off", {
            "vars": "all",
            "args": "after-used",
            "caughtErrors": "all",
            "ignoreRestSiblings": false,
            "ignoreUsingDeclarations": true,
            "reportUsedIgnorePattern": false
        }]
    },
     
    languageOptions: { globals: globals.browser } },
     pluginReact.configs.flat.recommended, 
]);
