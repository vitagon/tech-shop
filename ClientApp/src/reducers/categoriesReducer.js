import {RECEIVE_CATEGORIES} from '../actions/categoriesActions';

const initialState = {
  categories: [
    { id: 22, name: 'headphones', parentId: 0 },
    { id: 23, name: 'cellphones', parentId: 0 },
    { id: 24, name: 'video cards', parentId: 0 }
  ]
}

function categoriesReducer(state = initialState, action) {
  switch (action.type) {
    case RECEIVE_CATEGORIES:
      let obj = Object.assign({}, state, {
        categories: action.data
      });
      return obj;
    default:
      return state;
  }
}

export default categoriesReducer;