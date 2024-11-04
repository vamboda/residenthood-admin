// import { createStore, applyMiddleware } from 'redux';
// import {thunk} from 'redux-thunk'; // Correct import for redux-thunk
// import rootReducer from './reducers';
import { configureStore } from '@reduxjs/toolkit'
import rootReducer from './reducers'

export const store = configureStore({
    reducer: {
      appState: rootReducer,
    },
  })

// Infer the `RootState` and `AppDispatch` types from the store itself
export type RootState = ReturnType<typeof store.getState>

// Inferred type: {posts: PostsState, comments: CommentsState, users: UsersState}
export type AppDispatch = typeof store.dispatch

