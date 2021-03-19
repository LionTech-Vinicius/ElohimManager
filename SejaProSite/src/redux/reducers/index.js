import { combineReducers } from 'redux'
import { reducer as reduxFormRecucer } from 'redux-form'

export default combineReducers({
  form: reduxFormRecucer
})