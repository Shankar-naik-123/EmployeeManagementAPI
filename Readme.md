Enterprise pipeline architecture

PR Validation Pipeline
──────────────────────────────

Restore

↓

Build

↓

Unit Tests

↓

Sonar

──────────────────────────────


Main Pipeline
──────────────────────────────

Restore

↓

Build

↓

Unit Tests

↓

Publish

↓

Artifact

↓

Deploy Development

↓

Smoke Test

↓

Integration Tests

↓

QA Approval

↓

Deploy QA

↓

Smoke Test

↓

Production Approval

↓

Deploy Production

↓

Smoke Test