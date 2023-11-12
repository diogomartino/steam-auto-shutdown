module.exports = {
  root: true,
  env: { browser: true, es2020: true },
  extends: [
    'eslint:recommended',
    'plugin:@typescript-eslint/recommended',
    'plugin:react-hooks/recommended'
  ],
  ignorePatterns: ['dist', '.eslintrc.cjs', 'src/wailsjs/'],
  parser: '@typescript-eslint/parser',
  plugins: ['react-refresh', 'prettier', 'unused-imports'],
  rules: {
    'react-refresh/only-export-components': [
      'warn',
      { allowConstantExport: true }
    ],
    'prettier/prettier': [
      'error',
      {
        endOfLine: 'auto',
        useTabs: false
      }
    ],
    'unused-imports/no-unused-imports': 'warn',
    'unused-imports/no-unused-vars': [
      'warn',
      {
        vars: 'all',
        varsIgnorePattern: '^_',
        args: 'after-used',
        argsIgnorePattern: '^_'
      }
    ],
    '@typescript-eslint/no-explicit-any': 'off'
  }
};
