import { toggleComponent } from './../util/ToggleComponent';

export const RECEIVE_CATEGORIES = 'RECEIVE_CATEGORIES';
export const TOGGLE_ADD_CATEGORY_COMP = 'TOGGLE_ADD_CATEGORY_COMP';
export const TOGGLE_EDIT_CATEGORY_COMP = 'TOGGLE_EDIT_CATEGORY_COMP';
export const ADD_CATEGORY = 'ADD_CATEGORY';
export const SHOW_DELETE_CATEGORY_MODAL = 'SHOW_DELETE_CATEGORY_MODAL';
export const HIDE_DELETE_CATEGORY_MODAL = 'HIDE_DELETE_CATEGORY_MODAL';

const initialState = {
  categories: [
    { id: 22, name: 'headphones', parentId: 0 },
    { id: 23, name: 'cellphones', parentId: 0 },
    { id: 24, name: 'video cards', parentId: 0 }
  ],
  showAddCategoryComp: false,
  showEditCategoryComp: false,
  editCategoryCurrentItem: {},
  showDeleteCategoryModal: false,
  deleteCategoryCurrentItem: {}
}

function categoriesReducer(state = initialState, action) {
  switch (action.type) {
    case RECEIVE_CATEGORIES: {
      return Object.assign({}, state, {
        categories: action.data
      });
    }
    // this case is unused
    case ADD_CATEGORY: {
      return Object.assign({}, state, {
        categories: [
          ...state.categories,
          action.data
        ]
      });
    }
    case TOGGLE_ADD_CATEGORY_COMP: {
      if (!state.showAddCategoryComp) {
        closeAllComponents(state);
      }
      return Object.assign({}, state, {
        showAddCategoryComp: !state.showAddCategoryComp
      });
    }
    case TOGGLE_EDIT_CATEGORY_COMP: {
      let category = action.data;
      return toggleComponent(state, state.editCategoryCurrentItem, category, 'showEditCategoryComp', 'editCategoryCurrentItem', closeAllComponents);
    }
    case SHOW_DELETE_CATEGORY_MODAL: {
      return Object.assign({}, state, {
        showDeleteCategoryModal: true,
        deleteCategoryCurrentItem: action.data
      });
    }
    case HIDE_DELETE_CATEGORY_MODAL: {
      return Object.assign({}, state, {
        showDeleteCategoryModal: false
      });
    }
    default: {
      return state;
    }
  }
}

const closeAllComponents = (state) => {
  state.showAddCategoryComp = false;
  state.showEditCategoryComp = false;
}

export default categoriesReducer;