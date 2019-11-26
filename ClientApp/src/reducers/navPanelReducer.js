export const SHOW_SIDE_NAV_PANEL = 'SHOW_SIDE_NAV_PANEL';
export const HIDE_SIDE_NAV_PANEL = 'HIDE_SIDE_NAV_PANEL';
export const TOGGLE_SIDE_NAV_PANEL = 'TOGGLE_SIDE_NAV_PANEL';

const initialState = {
  showSideNavPanel: false
}

function navPanelReducer(state = initialState, action) {
  switch (action.type) {
    case SHOW_SIDE_NAV_PANEL: {
      return Object.assign({}, state, {
        showSideNavPanel: true
      })
    }
    case HIDE_SIDE_NAV_PANEL: {
      return Object.assign({}, state, {
        showSideNavPanel: false
      })
    }
    case TOGGLE_SIDE_NAV_PANEL: {
      return Object.assign({}, state, {
        showSideNavPanel: !state.showSideNavPanel
      })
    }
    default: {
      return state;
    }
  }
}

export default navPanelReducer;