
export interface InspectionState {
  value: number
}

// Define the initial state using that type
const initialState: InspectionState = {
  value: 2003123,
}

// Reducer function
function rootReducer(state = initialState, action: any) {
    switch (action.type) {
        default:
            return state;
    }
}

export default rootReducer;
  