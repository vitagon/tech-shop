
export const RECEIVE_CATEGORIES_TREE = 'RECEIVE_CATEGORIES_TREE';

const initialState = {
  categoriesTree: []
}

function categoriesReducer(state = initialState, action) {
  switch (action.type) {
    case RECEIVE_CATEGORIES_TREE: {
      return Object.assign({}, state, {
        categoriesTree: action.data
      });
    }
    default: {
      return state;
    }
  }
}

export default categoriesReducer;